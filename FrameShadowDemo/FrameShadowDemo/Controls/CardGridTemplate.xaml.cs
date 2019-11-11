using Xamarin.Forms;

namespace FrameShadowDemo
{
    public partial class CardGridTemplate : BaseGridTemplate
    {
        public CardGridTemplate()
        {
            InitializeComponent();
            HeightRequest = -1; //This line is important. This is used to reset the height to auto. Height is set to GridHeight by BaseGridTemplate.
        }
    }
}