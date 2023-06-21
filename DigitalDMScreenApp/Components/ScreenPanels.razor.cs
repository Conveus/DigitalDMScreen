namespace DigitalDMScreenApp.Components
{
    public partial class ScreenPanels
    {
        // Represents which panel is on screen
        private int ActivePanel = 2;

        // Increases active panel number
        private void Increment()
        {
            ActivePanel++;
        }

        // Decreases active panel number
        private void Decrement()
        {
            ActivePanel--;
        }
    }
}
