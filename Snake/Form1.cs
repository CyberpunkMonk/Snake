using System;
using System.Collections;
using System.Windows.Forms;

namespace Snake {
    public partial class Form1:Form {
        public Form1() {
            InitializeComponent();
            gameTimer.Interval=1000/60;//1000 Miliseconds (Timer interval) / 60 (desired frame rate)
            gameTimer.Tick+=new EventHandler(Update);
            gameTimer.Start();
        }
        private void Update(Object sender, EventArgs e) {
            //update logic here
            pbCanvas.Invalidate();//Every update will force picture box to invalidate, requiring re-rendering onto form.
        }
        private void Form1_KeyDown(Object sender, KeyEventArgs e) {
            Input.ChangeState(e.KeyCode,true);
        }
        private void Form1_KeyUp(Object sender, KeyEventArgs e) {
            Input.ChangeState(e.KeyCode,false);
        }
    }
}
