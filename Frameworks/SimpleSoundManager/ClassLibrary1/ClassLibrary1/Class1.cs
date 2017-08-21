﻿using StardewModdingAPI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundExample
{
    public class Class1 : Mod
    {
        SimpleSoundManager.SoundManager mySoundManager;

        public override void Entry(IModHelper helper)
        {
            mySoundManager = new SimpleSoundManager.SoundManager(Path.Combine(this.Helper.DirectoryPath,"Wave Bank2.xwb"), Path.Combine(this.Helper.DirectoryPath,"Sound Bank2.xsb"));
            StardewModdingAPI.Events.ControlEvents.KeyPressed += ControlEvents_KeyPressed;
        }
        
        /// <summary>
        /// Example for running code. Can call code whenever such as at a certain time of day, event, action occured, etc.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ControlEvents_KeyPressed(object sender, StardewModdingAPI.Events.EventArgsKeyPressed e)
        {
            if (e.KeyPressed == Microsoft.Xna.Framework.Input.Keys.J)
            {
                mySoundManager.playSound("sound1");
            }
            if (e.KeyPressed == Microsoft.Xna.Framework.Input.Keys.K)
            {
                mySoundManager.stopSound("sound1");
            }
            if (e.KeyPressed == Microsoft.Xna.Framework.Input.Keys.L)
            {
                mySoundManager.pauseSound("sound1");
            }
            if (e.KeyPressed == Microsoft.Xna.Framework.Input.Keys.O)
            {
                mySoundManager.resumeSound("sound1");
            }
        }
    }
}
