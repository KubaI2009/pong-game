namespace PongGame;

public partial class PongGameEngine : Form
{
    public PongGameEngine()
    {
        BoardX = 0;
        BoardY = 0;
        BoardWidth = 400;
        BoardHeight = 300;
        LabelHeight = 0;
        FormWidth = BoardWidth + 2 * BoardX;
        FormHeight = BoardHeight + 2 * BoardY + LabelHeight;
        
        InitializeComponent();
        Customize();
    }
}