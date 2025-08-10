namespace PongGame;

public partial class PongGameEngine : Form
{
    public PongGameEngine()
    {
        _ticks = 0;
        BoardX = 0;
        BoardY = 0;
        BoardWidth = 400;
        BoardHeight = 300;
        LabelHeight = 0;
        FormWidth = BoardWidth + 2 * BoardX;
        FormHeight = BoardHeight + 2 * BoardY + LabelHeight;
        RacketWidth = 5;
        DeathZoneWidth = RacketWidth > 1 ? RacketWidth - 1 : 1;
        
        InitializeComponent();
        Customize();
    }
}