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
<<<<<<< HEAD
                new ButtonInfo { buttonText = "Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Opens the main settings page for the menu."},
                new ButtonInfo { buttonText = "Mosa Speed", method =() => Mods.MOMS.MosaSpeed(), toolTip = "Weeeeeee"},
                new ButtonInfo { buttonText = "togglable placeholder"},
                new ButtonInfo { buttonText = "Platforms", method =() => Mods.MOMS.MosaSpeed(), toolTip = "Platforms Mod"},
                new ButtonInfo { buttonText = "togglable placeholder 2"},
                new ButtonInfo { buttonText = "Untag All", method =() => Mods.MOMS.UntagAll(), toolTip = "Untag everyone (Need to be master)"},
                new ButtonInfo { buttonText = "togglable placeholder 3"},
                new ButtonInfo { buttonText = "Long Arms", method =() => Mods.MOMS.LongArms(), toolTip = "Long Arms"},
                new ButtonInfo { buttonText = "togglable placeholder 4"},
                new ButtonInfo { buttonText = "Really Long Arms", method =() => Mods.MOMS.ReallyLongArms(), toolTip = "Longer Long Arms"},
                new ButtonInfo { buttonText = "togglable placeholder 5"},
                new ButtonInfo { buttonText = "Waterballoon Spam", method =() => Mods.MOMS.WaterBalloonSpammer(), toolTip = "Spam Water Balloons"},
                new ButtonInfo { buttonText = "togglable placeholder 6"},
                new ButtonInfo { buttonText = "Ghost Monkey", method =() => Mods.MOMS.GhostMonkey(), toolTip = "Turn Into a Ghost"},
                new ButtonInfo { buttonText = "togglable placeholder 7"},
                new ButtonInfo { buttonText = "Wall Walk", method =() => Mods.MOMS.Wallwalk(), toolTip = "Walk on Walls"},
                new ButtonInfo { buttonText = "togglable placeholder 8"},
                new ButtonInfo { buttonText = "Spaz Monkey", method =() => Mods.MOMS.SpazMonke(), toolTip = "Bros tweaking"},
                new ButtonInfo { buttonText = "togglable placeholder 9"},
=======
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
>>>>>>> parent of c85bdd3 (i forgor)
            },

            new ButtonInfo[] { // Settings
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Menu", method =() => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the settings for the menu."},
                new ButtonInfo { buttonText = "Movement", method =() => SettingsMods.MovementSettings(), isTogglable = false, toolTip = "Opens the movement settings for the menu."},
                new ButtonInfo { buttonText = "Projectile", method =() => SettingsMods.ProjectileSettings(), isTogglable = false, toolTip = "Opens the projectile settings for the menu."},
            },

            new ButtonInfo[] { // Menu Settings
<<<<<<< HEAD
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
                new ButtonInfo { buttonText = "Right Hand", enableMethod =() => SettingsMods.RightHand(), disableMethod =() => SettingsMods.LeftHand(), toolTip = "Puts the menu on your right hand."},
                new ButtonInfo { buttonText = "Notifications", enableMethod =() => SettingsMods.EnableNotifications(), disableMethod =() => SettingsMods.DisableNotifications(), enabled = !disableNotifications, toolTip = "Toggles the notifications."},
                new ButtonInfo { buttonText = "FPS Counter", enableMethod =() => SettingsMods.EnableFPSCounter(), disableMethod =() => SettingsMods.DisableFPSCounter(), enabled = fpsCounter, toolTip = "Toggles the FPS counter."},
                new ButtonInfo { buttonText = "Disconnect Button", enableMethod =() => SettingsMods.EnableDisconnectButton(), disableMethod =() => SettingsMods.DisableDisconnectButton(), enabled = disconnectButton, toolTip = "Toggles the disconnect button."},
=======
                new ButtonInfo { buttonText = "Return to Settings", method = () => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu." },
                new ButtonInfo { buttonText = "Right Hand", enableMethod = () => SettingsMods.RightHand(), disableMethod = () => SettingsMods.LeftHand(), toolTip = "Puts the menu on your right hand." },
                new ButtonInfo { buttonText = "Notifications", enableMethod = () => SettingsMods.EnableNotifications(), disableMethod = () => SettingsMods.DisableNotifications(), enabled = !disableNotifications, toolTip = "Toggles the notifications." },
                new ButtonInfo { buttonText = "FPS Counter", enableMethod = () => SettingsMods.EnableFPSCounter(), disableMethod = () => SettingsMods.DisableFPSCounter(), enabled = fpsCounter, toolTip = "Toggles the FPS counter." },
                new ButtonInfo { buttonText = "Disconnect sigma", enableMethod = () => SettingsMods.EnableDisconnectButton(), disableMethod = () => SettingsMods.DisableDisconnectButton(), enabled = disconnectButton, toolTip = "Toggles the disconnect button." },
                new ButtonInfo { buttonText = "Disconnect Button", overlapText = "Disconnect Button {Right Secondary}", method = () => Mods.Mods.changedisconnectbutton(), isTogglable = false, toolTip = "Toggles the disconnect button." },
>>>>>>> parent of c85bdd3 (i forgor)
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
