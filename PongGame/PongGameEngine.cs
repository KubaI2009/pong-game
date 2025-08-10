namespace PongGame;

public partial class PongGameEngine : Form
{
    public PongGameEngine()
    {
        FormWidth = 500;
        FormHeight = 600;
        BoardX = 0;
        BoardY = 0;
        BoardWidth = FormWidth - 2 * BoardX;
        BoardHeight = FormHeight - 2 * BoardY - 250;
        
        InitializeComponent();
        Customize();
    }
}