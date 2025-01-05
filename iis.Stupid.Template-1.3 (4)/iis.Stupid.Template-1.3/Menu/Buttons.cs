@ -1,27 + 1,26 @@
﻿using Oculus.Interaction;
using StupidTemplate.Classes;
using StupidTemplate.Mods;
using static StupidTemplate.Settings;

namespace StupidTemplate.Menu
{
    internal class Buttons
    {
        public static ButtonInfo[][] buttons = new ButtonInfo[][]
        {
            new ButtonInfo[] { // Main Mods
                new ButtonInfo { buttonText = "Settings", method = () => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Opens the main settings page for the menu." },
                new ButtonInfo { buttonText = "Mosa Speed", method = () => Mods.Mods.MosaSpeed(), toolTip = "Weeeeeee", disableMethod = () => Mods.Mods.FixSpeed() },
                new ButtonInfo { buttonText = "Platforms", method = () => Mods.Mods.Platforms(), toolTip = "Platforms Mod" },
                new ButtonInfo { buttonText = "Long Arms", method = () => Mods.Mods.LongArms(), toolTip = "Long Arms", disableMethod = () => Mods.Mods.NormalArms() },
                new ButtonInfo { buttonText = "Really Long Arms", method = () => Mods.Mods.ReallyLongArms(), toolTip = "Longer Long Arms", disableMethod = () => Mods.Mods.NormalArms() },
                new ButtonInfo { buttonText = "Ghost Monkey", method = () => Mods.Mods.GhostMonkey(), toolTip = "Turn Into a Ghost" },
                new ButtonInfo { buttonText = "Spaz Monkey", method = () => Mods.Mods.SpazMonke(), toolTip = "Bros tweaking" },
                new ButtonInfo { buttonText = "Fly", method = () => Mods.Mods.FlyMod(), toolTip = "Become Superman" },
                new ButtonInfo { buttonText = "No Clip", method = () => Mods.Mods.Noclip(), toolTip = "No colliders" },
                new ButtonInfo { buttonText = "Disconnect Buttogbn", method = () => Mods.Mods.DisconnectOnButton(), toolTip = "Press A To disconnect you" },
                new ButtonInfo { buttonText = "HGump Mod", method = () => Mods.Mods.hhdf(), toolTip = "sigma that discoconecnt oyuiukhm" },
                new ButtonInfo { buttonText = "wasd", method = () => Mods.Mods.wasd(), toolTip = "wasd" },
                new ButtonInfo { buttonText = "Juke", method = () => Mods.Mods.hhdf(), toolTip = "LAUNCH in the air" },
                new ButtonInfo { buttonText = "wasd", method = () => Mods.Mods.wasd(), toolTip = "wasd movemnt for computer" },
            },

            new ButtonInfo[] { // Settings
@ -37,7 +36,7 @@ namespace StupidTemplate.Menu
                new ButtonInfo { buttonText = "Right Hand", enableMethod = () => SettingsMods.RightHand(), disableMethod = () => SettingsMods.LeftHand(), toolTip = "Puts the menu on your right hand." },
                new ButtonInfo { buttonText = "Notifications", enableMethod = () => SettingsMods.EnableNotifications(), disableMethod = () => SettingsMods.DisableNotifications(), enabled = !disableNotifications, toolTip = "Toggles the notifications." },
                new ButtonInfo { buttonText = "FPS Counter", enableMethod = () => SettingsMods.EnableFPSCounter(), disableMethod = () => SettingsMods.DisableFPSCounter(), enabled = fpsCounter, toolTip = "Toggles the FPS counter." },
                new ButtonInfo { buttonText = "Disconnect sigma", enableMethod = () => SettingsMods.EnableDisconnectButton(), disableMethod = () => SettingsMods.DisableDisconnectButton(), enabled = disconnectButton, toolTip = "Toggles the disconnect button." },
                new ButtonInfo { buttonText = "Disconnect button enable", enableMethod = () => SettingsMods.EnableDisconnectButton(), disableMethod = () => SettingsMods.DisableDisconnectButton(), enabled = disconnectButton, toolTip = "Toggles the disconnect button." },
                new ButtonInfo { buttonText = "Disconnect Button", overlapText = "Disconnect Button {Right Secondary}", method = () => Mods.Mods.changedisconnectbutton(), isTogglable = false, toolTip = "Toggles the disconnect button." },
            },

