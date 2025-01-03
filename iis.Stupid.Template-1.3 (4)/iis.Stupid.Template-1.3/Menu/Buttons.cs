﻿using StupidTemplate.Classes;
using StupidTemplate.Mods;
using static StupidTemplate.Settings;

namespace StupidTemplate.Menu
{
    internal class Buttons
    {
        public static ButtonInfo[][] buttons = new ButtonInfo[][]
        {
            new ButtonInfo[] { // Main Mods
                new ButtonInfo { buttonText = "Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Opens the main settings page for the menu."},
                new ButtonInfo { buttonText = "Mosa Speed", method =() => Mods.Mods.MosaSpeed(), toolTip = "Weeeeeee"},
                new ButtonInfo { buttonText = "togglable placeholder"},
                new ButtonInfo { buttonText = "Platforms", method =() => Mods.Mods.PlatformsMod(), toolTip = "Platforms Mod"},
                new ButtonInfo { buttonText = "togglable placeholder 2"},
                new ButtonInfo { buttonText = "Untag All", method =() => Mods.Mods.UntagAll(), toolTip = "Untag everyone (Need to be master)"},
                new ButtonInfo { buttonText = "togglable placeholder 3"},
                new ButtonInfo { buttonText = "Long Arms", method =() => Mods.Mods.LongArms(), toolTip = "Long Arms"},
                new ButtonInfo { buttonText = "togglable placeholder 4"},
                new ButtonInfo { buttonText = "Really Long Arms", method =() => Mods.Mods.ReallyLongArms(), toolTip = "Longer Long Arms"},
                new ButtonInfo { buttonText = "togglable placeholder 5"},
                new ButtonInfo { buttonText = "Waterballoon Spam", method =() => Mods.Mods.WaterBalloonSpammer(), toolTip = "Spam Water Balloons"},
                new ButtonInfo { buttonText = "togglable placeholder 6"},
                new ButtonInfo { buttonText = "Ghost Monkey", method =() => Mods.Mods.GhostMonkey(), toolTip = "Turn Into a Ghost"},
                new ButtonInfo { buttonText = "togglable placeholder 7"},
            },

            new ButtonInfo[] { // Settings
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Menu", method =() => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the settings for the menu."},
                new ButtonInfo { buttonText = "Movement", method =() => SettingsMods.MovementSettings(), isTogglable = false, toolTip = "Opens the movement settings for the menu."},
                new ButtonInfo { buttonText = "Projectile", method =() => SettingsMods.ProjectileSettings(), isTogglable = false, toolTip = "Opens the projectile settings for the menu."},
            },

            new ButtonInfo[] { // Menu Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
                new ButtonInfo { buttonText = "Right Hand", enableMethod =() => SettingsMods.RightHand(), disableMethod =() => SettingsMods.LeftHand(), toolTip = "Puts the menu on your right hand."},
                new ButtonInfo { buttonText = "Notifications", enableMethod =() => SettingsMods.EnableNotifications(), disableMethod =() => SettingsMods.DisableNotifications(), enabled = !disableNotifications, toolTip = "Toggles the notifications."},
                new ButtonInfo { buttonText = "FPS Counter", enableMethod =() => SettingsMods.EnableFPSCounter(), disableMethod =() => SettingsMods.DisableFPSCounter(), enabled = fpsCounter, toolTip = "Toggles the FPS counter."},
                new ButtonInfo { buttonText = "Disconnect Button", enableMethod =() => SettingsMods.EnableDisconnectButton(), disableMethod =() => SettingsMods.DisableDisconnectButton(), enabled = disconnectButton, toolTip = "Toggles the disconnect button."},
            },

            new ButtonInfo[] { // Movement Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
            },

            new ButtonInfo[] { // Projectile Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the settings for the menu."},
            },
        };
    }
}