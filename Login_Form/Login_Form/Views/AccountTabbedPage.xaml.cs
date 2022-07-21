using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Login_Form.Models;

namespace Login_Form.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AccountTabbedPage : ContentPage
    {
        Leds _leds = new Leds();
        public AccountTabbedPage()
        {
            InitializeComponent();

            var sp = (StackLayout)this.ledcontent;

            foreach(Button led in sp.Children)
            {
                led.Clicked += (s, e) =>
                {
                    _leds.Value ^= 1 << led.TabIndex;
                };
            }

            _leds.Changed += (s, e) =>
            {
                int i = 0;
                foreach (Button led in sp.Children)
                {
                    led.Background = (_leds.Value & (1 << i++)) == 0 ? Xamarin.Forms.Brush.LightGray : Xamarin.Forms.Brush.Yellow;
                }
            };

            //var client = new MqttClient("broker.emqx.io");
            //var id = "20182405";
            //var topic = "test" + id;
            //client.Connect(id);
            //client.Subscribe(new string[] { topic }, new byte[] { 0 });

            //var sp = (StackLayout)this.ledcontent;
            //foreach(Button led in sp.Children)
            //{
            //    led.Clicked += (s, e) =>
            //    {
            //        _leds.Value ^= 1 << led.TabIndex;
            //        client.Publish(topic, Encoding.ASCII.GetBytes(_leds.Value.ToString()));
            //    };
            //}

            //client.MqttMsgPublishReceived += (s, e) =>
            //{
            //    Console.WriteLine(e.Topic + ": " + Encoding.ASCII.GetString(e.Message));
            //};


            //_leds.Changed += (s, e) =>
            //{
            //    int i = 0;
            //    foreach (Button led in sp.Children)
            //    {
            //        led.Background = (_leds.Value & (1 << i++)) == 0 ? Xamarin.Forms.Brush.LightGray : Xamarin.Forms.Brush.Green;
            //    }
            //};
        }
    }
}