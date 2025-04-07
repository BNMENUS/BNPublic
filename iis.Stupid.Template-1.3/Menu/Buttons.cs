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
        new ButtonInfo { buttonText = "Mosa Speed", method = () => MOMS.MosaSpeed(), toolTip = "Weeeeeee", disableMethod = () => MOMS.FixSpeed() },
        new ButtonInfo { buttonText = "Platforms", method = () => MOMS.Platforms(), toolTip = "Platforms Mod" },
        new ButtonInfo { buttonText = "Long Arms", method = () => MOMS.LongArms(), toolTip = "Long Arms", disableMethod = () => MOMS.NormalArms() },
        new ButtonInfo { buttonText = "Really Long Arms", method = () => MOMS.ReallyLongArms(), toolTip = "Longer Long Arms", disableMethod = () => MOMS.NormalArms() },
        new ButtonInfo { buttonText = "Ghost Monkey", method = () => MOMS.GhostMonkey(), toolTip = "Turn Into a Ghost" },
        new ButtonInfo { buttonText = "Spaz Monkey", method = () => MOMS.SpazMonke(), toolTip = "Bros tweaking" },
        new ButtonInfo { buttonText = "Fly", method = () => MOMS.FlyMod(), toolTip = "Become Superman" },
        new ButtonInfo { buttonText = "No Clip", method = () => MOMS.Noclip(), toolTip = "No colliders" },
        new ButtonInfo { buttonText = "Disconnect Buttogbn", method = () => MOMS.DisconnectOnButton(), toolTip = "Press A To disconnect you" },
        new ButtonInfo { buttonText = "HGump Mod", method = () => MOMS.hhdf(), toolTip = "sigma that discoconecnt oyuiukhm" },
        new ButtonInfo { buttonText = "wasd", method = () => MOMS.wasd(), toolTip = "wasd" },
    },

    new ButtonInfo[] { // Settings
        new ButtonInfo { buttonText = "Return to Main", method = () => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu." },
        new ButtonInfo { buttonText = "Menu", method = () => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the settings for the menu." },
        new ButtonInfo { buttonText = "Movement", method = () => SettingsMods.MovementSettings(), isTogglable = false, toolTip = "Opens the movement settings for the menu." },
        new ButtonInfo { buttonText = "Projectile", method = () => SettingsMods.ProjectileSettings(), isTogglable = false, toolTip = "Opens the projectile settings for the menu." },
        new ButtonInfo { buttonText = "AntiReport", method = () => MOMS.AntiReport(), isTogglable = true, toolTip = "If someone tries to report you, you disconnect" },
    },

    new ButtonInfo[] { // Menu Settings
        new ButtonInfo { buttonText = "Return to Settings", method = () => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu." },
        new ButtonInfo { buttonText = "Right Hand", enableMethod = () => SettingsMods.RightHand(), disableMethod = () => SettingsMods.LeftHand(), toolTip = "Puts the menu on your right hand." },
        new ButtonInfo { buttonText = "Notifications", enableMethod = () => SettingsMods.EnableNotifications(), disableMethod = () => SettingsMods.DisableNotifications(), enabled = !disableNotifications, toolTip = "Toggles the notifications." },
        new ButtonInfo { buttonText = "FPS Counter", enableMethod = () => SettingsMods.EnableFPSCounter(), disableMethod = () => SettingsMods.DisableFPSCounter(), enabled = fpsCounter, toolTip = "Toggles the FPS counter." },
        new ButtonInfo { buttonText = "Disconnect sigma", enableMethod = () => SettingsMods.EnableDisconnectButton(), disableMethod = () => SettingsMods.DisableDisconnectButton(), enabled = disconnectButton, toolTip = "Toggles the disconnect button." },
        new ButtonInfo { buttonText = "Disconnect Button", overlapText = "Disconnect Button {Right Secondary}", method = () => MOMS.changedisconnectbutton(), isTogglable = false, toolTip = "Toggles the disconnect button." },
    },

    new ButtonInfo[] { // Movement Settings
        new ButtonInfo { buttonText = "Return to Settings", method = () => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu." },
    },
    new ButtonInfo[] { // Projectile Settings
                new ButtonInfo { buttonText = "Return to Settings", method = () => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the settings for the menu." },
    },
    };

    }
}
