using PongGame.util;
using Timer = System.Threading.Timer;

namespace PongGame;

partial class PongGameEngine
{
    public int FormWidth
    {
        get;
        private set;
    }
    
    public int FormHeight
    {
        get;
        private set;
    }

    public int BoardX
    {
        get;
        private set;
    }

    public int BoardY
    {
        get;
        private set;
    }
    
    public int BoardWidth
    {
        get;
        private set;
    }
    
    public int BoardHeight
    {
        get;
        private set;
    }

    public int LabelHeight
    {
        get;
        private set;
    }

    public System.Timers.Timer GameLoop
    {
        get;
        private set;
    }
    
    public RectangularBoard Board
    {
        get;
        private set;
    }

    public PongBall Ball
    {
        get;
        private set;
    }
    
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PongGameEngine));
        SuspendLayout();
        // 
        // PongGameEngine
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
        Text = "";
        ResumeLayout(false);
    }

    #endregion

    private void Customize()
    {
        SuspendLayout();
        
        //basic customization
        ClientSize = new System.Drawing.Size(FormWidth, FormHeight);
        Text = "Pong Game";
        BackColor = Color.Black;
        
        //board initialization
        Board = new RectangularBoard(BoardX, BoardY, BoardWidth, BoardHeight, this);
        
        //pong ball initialization
        Ball = new PongBall(BoardX, BoardY + BoardHeight / 2, new Vector2Int(1, 1), Board, this);
        
        InitializeGameLoop();
        
        ResumeLayout(false);
    }

    private void InitializeGameLoop()
    {
        GameLoop = new System.Timers.Timer();
        GameLoop.Interval = 1;
        GameLoop.Elapsed += (sender, args) => Update();
        GameLoop.Start();
    }

    private void Update()
    {
        Ball.Update();
    }
}