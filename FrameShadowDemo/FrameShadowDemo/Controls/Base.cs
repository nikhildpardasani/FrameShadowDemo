using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FrameShadowDemo
{
    public class BaseGridTemplate : StackLayout
    {
        public BaseGridTemplate()
        {
            this.SetDynamicResource(HeightRequestProperty, "GridHeight");
            Margin = new Thickness(0);
            Orientation = StackOrientation.Vertical;
            Spacing = 0;
            TapGestureRecognizer tap = new TapGestureRecognizer();
            tap.Tapped += Tap_Tapped;
            GestureRecognizers.Add(tap);
        }

        private async void Tap_Tapped(object sender, EventArgs e)
        {
            if (!(sender is CardGridTemplate)) // This condition is to stop CardGridTemplate from flashing when tapped.
            {
                this.SetDynamicResource(BackgroundColorProperty, "GridTappedColor");
                await Task.Delay(100);
                this.BackgroundColor = Color.Default;
            }
        }

        public static readonly BindableProperty AsyncBtnCmdProperty = BindableProperty.Create(nameof(AsyncBtnCmd), typeof(MvvmHelpers.Commands.AsyncCommand<string>), typeof(BaseGridTemplate), default(MvvmHelpers.Commands.AsyncCommand));
        public static readonly BindableProperty OpenPageAsyncCmdProperty = BindableProperty.Create(nameof(OpenPageAsyncCmd), typeof(MvvmHelpers.Commands.AsyncCommand<string>), typeof(BaseGridTemplate), default(MvvmHelpers.Commands.AsyncCommand));
        public static readonly BindableProperty BtnCmdProperty = BindableProperty.Create(nameof(BtnCmd), typeof(Command), typeof(BaseGridTemplate), default(Command));
        public static readonly BindableProperty BtnStateProperty = BindableProperty.Create(nameof(BtnState), typeof(string), typeof(BaseGridTemplate), "D");
        public static readonly BindableProperty BtnTextProperty = BindableProperty.Create(nameof(BtnText),   typeof(string), typeof(BaseGridTemplate), default(string));
        public static readonly BindableProperty Column0Property = BindableProperty.Create(nameof(Column0),   typeof(string), typeof(BaseGridTemplate), default(string));
        public static readonly BindableProperty Column1Property = BindableProperty.Create(nameof(Column1),   typeof(string), typeof(BaseGridTemplate), default(string));
        public static readonly BindableProperty Column2Property = BindableProperty.Create(nameof(Column2),   typeof(string), typeof(BaseGridTemplate), default(string));
        public static readonly BindableProperty Column3Property = BindableProperty.Create(nameof(Column3),   typeof(string), typeof(BaseGridTemplate), default(string));
        public static readonly BindableProperty Column4Property = BindableProperty.Create(nameof(Column4),   typeof(string), typeof(BaseGridTemplate), default(string));
        public static readonly BindableProperty Column5Property = BindableProperty.Create(nameof(Column5),   typeof(string), typeof(BaseGridTemplate), default(string));
        public static readonly BindableProperty Column6Property = BindableProperty.Create(nameof(Column6),   typeof(string), typeof(BaseGridTemplate), default(string));
        public static readonly BindableProperty F1StateProperty = BindableProperty.Create(nameof(F1State), typeof(string), typeof(BaseGridTemplate), default(string));
        public static readonly BindableProperty F1TextProperty = BindableProperty.Create(nameof(F1Text), typeof(string), typeof(BaseGridTemplate), default(string));
        public static readonly BindableProperty F2StateProperty = BindableProperty.Create(nameof(F2State), typeof(string), typeof(BaseGridTemplate), default(string));
        public static readonly BindableProperty F2TextProperty = BindableProperty.Create(nameof(F2Text), typeof(string), typeof(BaseGridTemplate), default(string));
        public static readonly BindableProperty F3StateProperty = BindableProperty.Create(nameof(F3State), typeof(string), typeof(BaseGridTemplate), default(string));
        public static readonly BindableProperty F3TextProperty = BindableProperty.Create(nameof(F3Text), typeof(string), typeof(BaseGridTemplate), default(string));
        public static readonly BindableProperty F4StateProperty = BindableProperty.Create(nameof(F4State), typeof(string), typeof(BaseGridTemplate), default(string));
        public static readonly BindableProperty F4TextProperty = BindableProperty.Create(nameof(F4Text), typeof(string), typeof(BaseGridTemplate), default(string));
        public static readonly BindableProperty F5StateProperty = BindableProperty.Create(nameof(F5State), typeof(string), typeof(BaseGridTemplate), default(string));
        public static readonly BindableProperty F5TextProperty = BindableProperty.Create(nameof(F5Text), typeof(string), typeof(BaseGridTemplate), default(string));
        public static readonly BindableProperty HStateProperty = BindableProperty.Create(nameof(HState), typeof(string), typeof(BaseGridTemplate), default(string));
        public static readonly BindableProperty HTextProperty =  BindableProperty.Create(nameof(HText), typeof(string), typeof(BaseGridTemplate), default(string));
        public static readonly BindableProperty HeaderProperty = BindableProperty.Create(nameof(Header), typeof(bool), typeof(BaseGridTemplate), false);
        public static readonly BindableProperty IconProperty = BindableProperty.Create(nameof(Icon), typeof(string), typeof(BaseGridTemplate), default(string));
        public static readonly BindableProperty IsToggledProperty = BindableProperty.Create("IsToggled", typeof(bool), typeof(BaseGridTemplate), defaultBindingMode: BindingMode.TwoWay, defaultValue: default(bool));
        public static readonly BindableProperty LabelVisibleProperty = BindableProperty.Create(nameof(LabelVisible), typeof(bool), typeof(BaseGridTemplate), true);
        public static readonly BindableProperty MessageProperty = BindableProperty.Create(nameof(Message), typeof(string), typeof(BaseGridTemplate), default(string));
        public static readonly BindableProperty PhraseIdProperty = BindableProperty.Create(nameof(PhraseId), typeof(string), typeof(BaseGridTemplate), default(string));
        public static readonly BindableProperty RowIdProperty = BindableProperty.Create(nameof(RowId), typeof(int), typeof(BaseGridTemplate), default(int));
        public static readonly BindableProperty RowProperty = BindableProperty.Create(nameof(Row), typeof(string), typeof(BaseGridTemplate), default(string));
        public static readonly BindableProperty SeparatorProperty = BindableProperty.Create(nameof(Separator), typeof(bool), typeof(BaseGridTemplate), false);
        public static readonly BindableProperty StateProperty = BindableProperty.Create(nameof(State), typeof(string), typeof(BaseGridTemplate), default(string));
        public static readonly BindableProperty Tap2CommandProperty = BindableProperty.Create(nameof(Tap2Command), typeof(Command), typeof(BaseGridTemplate), default(Command));
        public static readonly BindableProperty TapCommandParamProperty = BindableProperty.Create(nameof(TapCommandParam), typeof(object), typeof(BaseGridTemplate), default(object));
        public static readonly BindableProperty TapCommandProperty = BindableProperty.Create(nameof(TapCommand), typeof(Command), typeof(BaseGridTemplate), default(Command));
        public static readonly BindableProperty TapF1CommandProperty = BindableProperty.Create(nameof(TapF1Command), typeof(Command), typeof(BaseGridTemplate), default(Command));
        public static readonly BindableProperty TapF2CommandProperty = BindableProperty.Create(nameof(TapF2Command), typeof(Command), typeof(BaseGridTemplate), default(Command));
        public static readonly BindableProperty TapF3CommandProperty = BindableProperty.Create(nameof(TapF3Command), typeof(Command), typeof(BaseGridTemplate), default(Command));
        public static readonly BindableProperty TapF4CommandProperty = BindableProperty.Create(nameof(TapF4Command), typeof(Command), typeof(BaseGridTemplate), default(Command));
        public static readonly BindableProperty TapF5CommandProperty = BindableProperty.Create(nameof(TapF5Command), typeof(Command), typeof(BaseGridTemplate), default(Command));
        public static readonly BindableProperty TapHCommandProperty = BindableProperty.Create(nameof(TapHCommand), typeof(Command), typeof(BaseGridTemplate), default(Command));
        public static readonly BindableProperty Text1Property = BindableProperty.Create(nameof(Text1), typeof(string), typeof(BaseGridTemplate), default(string));
        public static readonly BindableProperty Text2Property = BindableProperty.Create(nameof(Text2), typeof(string), typeof(BaseGridTemplate), default(string));
        public static readonly BindableProperty Text3Property = BindableProperty.Create(nameof(Text3), typeof(string), typeof(BaseGridTemplate), default(string));
        public static readonly BindableProperty Text4Property = BindableProperty.Create(nameof(Text4), typeof(string), typeof(BaseGridTemplate), default(string));
        public static readonly BindableProperty Text5Property = BindableProperty.Create(nameof(Text5), typeof(string), typeof(BaseGridTemplate), default(string));
        public static readonly BindableProperty ToggledCommandProperty = BindableProperty.Create(nameof(ToggledCommand), typeof(Command), typeof(BaseGridTemplate), default(Command));

        public MvvmHelpers.Commands.AsyncCommand<string> AsyncBtnCmd { get => (MvvmHelpers.Commands.AsyncCommand<string>)GetValue(AsyncBtnCmdProperty); set => SetValue(AsyncBtnCmdProperty, value); }
        public MvvmHelpers.Commands.AsyncCommand<string> OpenPageAsyncCmd { get => (MvvmHelpers.Commands.AsyncCommand<string>)GetValue(OpenPageAsyncCmdProperty); set => SetValue(OpenPageAsyncCmdProperty, value); }
        public Command BtnCmd { get => (Command)GetValue(BtnCmdProperty); set => SetValue(BtnCmdProperty, value); }
        public Command Tap2Command { get => (Command)GetValue(Tap2CommandProperty); set => SetValue(Tap2CommandProperty, value); }
        public Command TapCommand { get => (Command)GetValue(TapCommandProperty); set => SetValue(TapCommandProperty, value); }
        public Command TapF1Command { get => (Command)GetValue(TapF1CommandProperty); set => SetValue(TapF1CommandProperty, value); }
        public Command TapF2Command { get => (Command)GetValue(TapF2CommandProperty); set => SetValue(TapF2CommandProperty, value); }
        public Command TapF3Command { get => (Command)GetValue(TapF3CommandProperty); set => SetValue(TapF3CommandProperty, value); }
        public Command TapF4Command { get => (Command)GetValue(TapF4CommandProperty); set => SetValue(TapF4CommandProperty, value); }
        public Command TapF5Command { get => (Command)GetValue(TapF5CommandProperty); set => SetValue(TapF5CommandProperty, value); }
        public Command TapHCommand { get => (Command)GetValue(TapHCommandProperty); set => SetValue(TapHCommandProperty, value); }
        public Command ToggledCommand { get => (Command)GetValue(ToggledCommandProperty); set => SetValue(ToggledCommandProperty, value); }
        public bool Header { get => (bool)GetValue(HeaderProperty); set => SetValue(HeaderProperty, value); }
        public bool IsToggled { get => (bool)GetValue(IsToggledProperty); set => SetValue(IsToggledProperty, value); }
        public string Icon { get => (string)GetValue(IconProperty); set => SetValue(IconProperty, value); }
        public bool LabelVisible { get => (bool)GetValue(LabelVisibleProperty); set => SetValue(LabelVisibleProperty, value); }
        public bool Separator { get => (bool)GetValue(SeparatorProperty); set => SetValue(SeparatorProperty, value); }
        public string PhraseId { get => (string)GetValue(PhraseIdProperty); set => SetValue(PhraseIdProperty, value); }
        public int RowId { get => (int)GetValue(RowIdProperty); set => SetValue(RowIdProperty, value); }
        public object TapCommandParam { get => (object)GetValue(TapCommandParamProperty); set => SetValue(TapCommandParamProperty, value); }
        public string BtnState { get => (string)GetValue(BtnStateProperty); set => SetValue(BtnStateProperty, value); }
        public string BtnText { get => (string)GetValue(BtnTextProperty); set => SetValue(BtnTextProperty, value); }
        public string Column0 { get => (string)GetValue(Column0Property); set => SetValue(Column0Property, value); }
        public string Column1 { get => (string)GetValue(Column1Property); set => SetValue(Column1Property, value); }
        public string Column2 { get => (string)GetValue(Column2Property); set => SetValue(Column2Property, value); }
        public string Column3 { get => (string)GetValue(Column3Property); set => SetValue(Column3Property, value); }
        public string Column4 { get => (string)GetValue(Column4Property); set => SetValue(Column4Property, value); }
        public string Column5 { get => (string)GetValue(Column5Property); set => SetValue(Column5Property, value); }
        public string Column6 { get => (string)GetValue(Column6Property); set => SetValue(Column6Property, value); }
        public string F1State { get => (string)GetValue(F1StateProperty); set => SetValue(F1StateProperty, value); }
        public string F1Text { get => (string)GetValue(F1TextProperty); set => SetValue(F1TextProperty, value); }
        public string F2State { get => (string)GetValue(F2StateProperty); set => SetValue(F2StateProperty, value); }
        public string F2Text { get => (string)GetValue(F2TextProperty); set => SetValue(F2TextProperty, value); }
        public string F3State { get => (string)GetValue(F3StateProperty); set => SetValue(F3StateProperty, value); }
        public string F3Text { get => (string)GetValue(F3TextProperty); set => SetValue(F3TextProperty, value); }
        public string F4State { get => (string)GetValue(F4StateProperty); set => SetValue(F4StateProperty, value); }
        public string F4Text { get => (string)GetValue(F4TextProperty); set => SetValue(F4TextProperty, value); }
        public string F5State { get => (string)GetValue(F5StateProperty); set => SetValue(F5StateProperty, value); }
        public string F5Text { get => (string)GetValue(F5TextProperty); set => SetValue(F5TextProperty, value); }
        public string HState { get => (string)GetValue(HStateProperty); set => SetValue(HStateProperty, value); }
        public string HText { get => (string)GetValue(HTextProperty); set => SetValue(HTextProperty, value); }
        public string Message { get => (string)GetValue(MessageProperty); set => SetValue(MessageProperty, value); }
        public string Row { get => (string)GetValue(RowProperty); set => SetValue(RowProperty, value); }
        public string State { get => (string)GetValue(StateProperty); set => SetValue(StateProperty, value); }
        public string Text1 { get => (string)GetValue(Text1Property); set => SetValue(Text1Property, value); }
        public string Text2 { get => (string)GetValue(Text2Property); set => SetValue(Text2Property, value); }
        public string Text3 { get => (string)GetValue(Text3Property); set => SetValue(Text3Property, value); }
        public string Text4 { get => (string)GetValue(Text4Property); set => SetValue(Text4Property, value); }
        public string Text5 { get => (string)GetValue(Text5Property); set => SetValue(Text5Property, value); }


        public static BindableProperty IsDisabledProperty =
      BindableProperty.Create(nameof(IsDisabled), typeof(bool), typeof(BaseGridTemplate), default(bool), propertyChanged: IsDisabledPropertyPropertyChanged);

        public bool IsDisabled
        {
            get { return (bool)GetValue(IsDisabledProperty); }
            set { SetValue(IsDisabledProperty, value); }
        }

        private static void IsDisabledPropertyPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if ((bool)newValue)
            {
                BaseGridTemplate customFrame = bindable as BaseGridTemplate;
                customFrame.IsEnabled = false;
                //customFrame.Opacity = 0.5;
            }
            else
            {
                BaseGridTemplate customFrame = bindable as BaseGridTemplate;
                customFrame.IsEnabled = true;
                //customFrame.Opacity = 1;
            }
        }
    }
}