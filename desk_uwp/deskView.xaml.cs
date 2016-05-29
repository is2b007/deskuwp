using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Input.Inking;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Threading.Tasks;
using Windows.Storage.Streams;
using System.Runtime.Serialization;
using deskx_uwp.protobuf;
using System.Net;
using Google.Protobuf;
using Windows.Security.Cryptography;
using System.IO.Compression;
using System.Threading;
using Windows.ApplicationModel.Background;
using Windows.System;
using desk_uwp.protobuf;
using Windows.System.Threading;
using Windows.UI.Core;
using Windows.UI.Popups;
using Windows.UI.WebUI;
using Windows.UI.Xaml.Media.Imaging;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace desk_uwp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DeskView : Page
    {
        InkDataManager _inkCollector;
        MessageDataManager _messageDealer;
        public DeskView()
        {
              this.InitializeComponent();
            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            InkCanvas.InkPresenter.InputDeviceTypes =
            Windows.UI.Core.CoreInputDeviceTypes.Mouse |
            Windows.UI.Core.CoreInputDeviceTypes.Pen |
            Windows.UI.Core.CoreInputDeviceTypes.Touch;

            // Set initial ink stroke attributes.
            InkDrawingAttributes drawingAttributes = new InkDrawingAttributes();
            drawingAttributes.Color = Windows.UI.Colors.Black;
            drawingAttributes.IgnorePressure = false;
            drawingAttributes.FitToCurve = true;
            InkCanvas.InkPresenter.UpdateDefaultDrawingAttributes(drawingAttributes);
            InkCanvas.InkPresenter.StrokeContainer.GetStrokes();
            _inkCollector = new InkDataManager(InkCanvas);
            _messageDealer = new MessageDataManager(ChatBox);
        }

        private async System.Threading.Tasks.Task SaveStrokesTask()
        {
            await _inkCollector.SendInk();
        }


        private void OnPenColorChanged(object sender, SelectionChangedEventArgs e)
        {
            if (InkCanvas == null) return;
            InkDrawingAttributes drawingAttributes =
                InkCanvas.InkPresenter.CopyDefaultDrawingAttributes();

            var comboBoxItem = (ComboBoxItem)PenColor.SelectedItem;
            Header.Text = App.CurrentSession.Title;
            if (comboBoxItem?.Content != null)
            {
                string value = comboBoxItem.Content.ToString();

                switch (value)
                {
                    case "Black":
                        drawingAttributes.Color = Windows.UI.Colors.Black;
                        break;
                    case "Red":
                        drawingAttributes.Color = Windows.UI.Colors.Red;
                        break;
                    case "Green":
                        drawingAttributes.Color = Windows.UI.Colors.Green;
                        break;
                    case "Yellow":
                        drawingAttributes.Color = Windows.UI.Colors.Yellow;
                        break;
                    case "Blue":
                        drawingAttributes.Color = Windows.UI.Colors.Blue;
                        break;
                    default:
                        drawingAttributes.Color = Windows.UI.Colors.Black;
                        break;
                }
            }
            ;

            InkCanvas.InkPresenter.UpdateDefaultDrawingAttributes(drawingAttributes);
        }

        private async void saveStroke_Click(object sender, RoutedEventArgs e)
        {
            var picker = new Windows.Storage.Pickers.FileOpenPicker();
            picker.ViewMode = Windows.Storage.Pickers.PickerViewMode.Thumbnail;
            picker.SuggestedStartLocation =
                Windows.Storage.Pickers.PickerLocationId.PicturesLibrary;
            picker.FileTypeFilter.Add(".jpg");
            picker.FileTypeFilter.Add(".jpeg");
            picker.FileTypeFilter.Add(".png");

            Windows.Storage.StorageFile file = await picker.PickSingleFileAsync();
            if (file != null)
            {
                // Application now has read/write access to the picked file
                using (IRandomAccessStream fileStream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read))
                {
                    // Set the image source to the selected bitmap
                    BitmapImage bitmapImage = new BitmapImage();

                    await bitmapImage.SetSourceAsync(fileStream);
                    ImageBox.Source = bitmapImage;
                    ImageBox.Stretch = Stretch.Uniform;
                }

            }
            else
            {
                var dialog = new MessageDialog("Can't load file.");
                await dialog.ShowAsync();
            }

        }

        private async void inkCanvas_Loaded(object sender, RoutedEventArgs e)
        {
            //          When the inkcanvas loads begin to start sending inkdata to server.

            await _inkCollector.SendInk();
            
        }

        private async void InkCanvas_Loading(FrameworkElement sender, object args)
        {
            await _inkCollector.GetInk();
        }

        private async void SendButton_Click(object sender, RoutedEventArgs e)
        {
            await _messageDealer.SendMessage(ChatField.Text);
            ChatField.Text = "";
        }

        private async void ChatBox_Loaded(object sender, RoutedEventArgs e)
        {
            await _messageDealer.GetMessages();
        }

        private async void ChatField_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == VirtualKey.Enter)
            {
                await _messageDealer.SendMessage(ChatField.Text);
                ChatField.Text = "";
            }
        }

        private async void BackButton_Click(object sender, RoutedEventArgs e)
        {
            _inkCollector.StopTransmitting();
            _messageDealer.StopTransmitting();
            await SessionManager.UpdateSession();
            this.Frame.Navigate(typeof(SessionView));
        }
    }
}
