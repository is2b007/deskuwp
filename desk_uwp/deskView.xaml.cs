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
using desk_uwp.protobuf;
using Windows.System.Threading;
using Windows.UI.Core;
using Windows.UI.WebUI;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace desk_uwp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DeskView : Page
    {
        InkDataManager _inkCollector;
        public DeskView()
        {
            this.InitializeComponent();

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

            string value = ((ComboBoxItem)PenColor.SelectedItem).Content.ToString();

            switch (value)
            {
                case "Black":
                    drawingAttributes.Color = Windows.UI.Colors.Black;
                    break;
                case "Red":
                    drawingAttributes.Color = Windows.UI.Colors.Red;
                    break;
                default:
                    drawingAttributes.Color = Windows.UI.Colors.Black;
                    break;
            };

            InkCanvas.InkPresenter.UpdateDefaultDrawingAttributes(drawingAttributes);
        }

        private void inkCanvas_PointerMoved(object sender, PointerRoutedEventArgs e)
        {

        }

        private async void saveStroke_Click(object sender, RoutedEventArgs e)
        {
//            DEBUG
            await _inkCollector.SendInk();
        }

        private async void inkCanvas_Loaded(object sender, RoutedEventArgs e)
        {
//          When the inkcanvas loads begin to start sending inkdata to server.
            await _inkCollector.SendInk();
        }
    }
}
