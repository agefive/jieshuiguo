using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace 接水果

{
    public partial class Gameload : Form
    {
        public Gameload()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            事实监听.Enabled = true;
            事实监听.Interval = 10;
            游戏时间.Enabled = true;
            游戏时间.Interval = 1000;
        }
        //生成角色和凋落物
        Worker worker=new Worker();
        Item item1 = new Item();
        Item item2 = new Item();
        Item item3 = new Item();
        Item item4 = new Item();
        Item item5 = new Item();
        Item item6 = new Item();
        Item item7 = new Item();
        Item item8 = new Item();
        public static int money = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //对角色进行操控   
            if (Keyboard.IsKeyDown(Keys.Left))
            {
                 worker.posX-= worker.speed;
                if(worker.posX < 0)worker.posX = 400;
            }
            else if (Keyboard.IsKeyDown(Keys.Right))
            {
                worker.posX += worker.speed;
                if(worker.posX >440)worker.posX = -60;
            }
            this.KeyDown += Keyboard.OnKeyDown;
            this.KeyUp += Keyboard.OnKeyUp;
            pictureWorker.Location = new Point((int)worker.posX,(int)worker.posY);
            label2.Text = "得分：" + money.ToString();
            itemdown();
            penzhuang();
        }
        
        public void penzhuang()
        {
            if((item1.posX + item1.w < worker.posX)||(worker.posX + worker.w < item1.posX)||(item1.posY + item1.h < worker.posY)||(worker.posY + worker.h < item1.posY)){
                
            }
            else
            {
                money++;
                item1.posY = item1.PosY();
                item1.posX = item1.PosX();
            }
            if ((item2.posX + item2.w < worker.posX) || (worker.posX + worker.w < item2.posX) || (item2.posY + item2.h < worker.posY) || (worker.posY + worker.h < item2.posY))
            {
                
            }
            else
            {
                money++;
                item2.posY = item2.PosY();
                item2.posX = item2.PosX();
            }
            if ((item3.posX + item3.w < worker.posX) || (worker.posX + worker.w < item3.posX) || (item3.posY + item3.h < worker.posY) || (worker.posY + worker.h < item3.posY))
            {
                
            }
            else
            {
                gameOver();
            }
            if ((item4.posX + item4.w < worker.posX) || (worker.posX + worker.w < item4.posX) || (item4.posY + item4.h < worker.posY) || (worker.posY + worker.h < item4.posY))
            {
                
            }
            else
            {
                gameOver();
            }
            if ((item5.posX + item5.w < worker.posX) || (worker.posX + worker.w < item5.posX) || (item5.posY + item5.h < worker.posY) || (worker.posY + worker.h < item5.posY))
            {
                
            }
            else
            {
                gameOver(); ;
            }
            if ((item6.posX + item6.w < worker.posX) || (worker.posX + worker.w < item6.posX) || (item6.posY + item6.h < worker.posY) || (worker.posY + worker.h < item6.posY))
            {
                
            }
            else
            {
                gameOver();
            }
            if ((item7.posX + item7.w < worker.posX) || (worker.posX + worker.w < item7.posX) || (item7.posY + item7.h < worker.posY) || (worker.posY + worker.h < item7.posY))
            {
                
            }
            else
            {
                gameOver();
            }
            if ((item8.posX + item8.w < worker.posX) || (worker.posX + worker.w < item8.posX) || (item8.posY + item8.h < worker.posY) || (worker.posY + worker.h < item8.posY))
            {
                
            }
            else
            {
                gameOver();
            }
        }
        public void gameOver()
        {
            new Gameover().Show();
            this.Close();          
        }
        //碰撞箱 返回数字1(加分)，2（结束），-1（无视）
        public void itemdown()
        {
            item1.posY += item1.speed;
            if (item1.posY > 800)
            {
                item1.posY = item1.PosY();
                item1.posX = item1.PosX();
            }
            item2.posY += item2.speed;
            if (item2.posY > 800)
            {
                item2.posY = item2.PosY();
                item2.posX = item2.PosX();
            }
            item3.posY += item3.speed;
            if (item3.posY > 800)
            {
                item3.posY = item3.PosY();
                item3.posX = item3.PosX();
            }
            item4.posY += item4.speed;
            if (item4.posY > 800)
            {
                item4.posY = item4.PosY();
                item4.posX = item4.PosX();         }
            item5.posY += item5.speed;
            if (item5.posY > 800)
            {
                item5.posY = item5.PosY();
                item5.posX = item5.PosX();
            }
            item6.posY += item6.speed;
            if (item6.posY > 800)
            {
                item6.posY = item6.PosY();
                item6.posX = item6.PosX();
            }
            item7.posY += item7.speed;
            if (item7.posY > 800)
            {
                item7.posY = item7.PosY();
                item7.posX = item7.PosX();
            }
            item8.posY += item8.speed;
            if (item8.posY > 800)
            {
                item8.posY = item8.PosY();
                item8.posX = item8.PosX();
            }

            apple1.Location = new Point((int)item1.posX, (int)item1.posY);
            apple2.Location = new Point((int)item2.posX, (int)item2.posY);
            apple3.Location = new Point((int)item3.posX, (int)item3.posY);
            apple4.Location = new Point((int)item4.posX, (int)item4.posY);
            apple5.Location = new Point((int)item5.posX, (int)item5.posY);
            apple6.Location = new Point((int)item6.posX, (int)item6.posY);
            apple7.Location = new Point((int)item7.posX, (int)item7.posY);
            apple8.Location = new Point((int)item8.posX, (int)item8.posY);
        }
        //障碍物下降
        public void itemspeed()
        {
            item1.speed += 0.3;
            item2.speed += 0.3;
            item3.speed += 0.3;
            item4.speed += 0.3;
            item5.speed += 0.3;
            item6.speed += 0.3;
            item7.speed += 0.3;
            item8.speed += 0.3;
        }
        //根据时间进行难度调整       
        int timec = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            timec++;
            if (timec % 5==0) itemspeed();
            label1.Text = "时间:"+timec.ToString();
        }
        //游戏时间       
        public static class Keyboard
        {
            
            private static readonly HashSet<Keys> keys = new HashSet<Keys>();

            public static void OnKeyDown(object sender, KeyEventArgs e)
            {
                if (keys.Contains(e.KeyCode) == false)
                {
                    keys.Add(e.KeyCode);
                }
            }
            public static void OnKeyUp(object sender, KeyEventArgs e)
            {
                if (keys.Contains(e.KeyCode))
                {
                    keys.Remove(e.KeyCode);
                }
            }

            public static bool IsKeyDown(Keys key)
            {
                return keys.Contains(key);
            }
        }
        //键盘监听
    }
}
