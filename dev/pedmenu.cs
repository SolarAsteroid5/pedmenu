using System;
using System.Threading.Tasks;
using PoliceFunctions_API.Functions;
using CitizenFX.Core;
using CitizenFX.Core.Native;
using CitizenFX.Core.UI;
using NativeUI;

namespace PedMenu
{
    public class MainMenu : BaseScript
    {
        private MenuPool _menuPool;
        private UIMenu mainMenu;
            
        public void PolicePeds(UIMenu menu)
        {
            var PolicePedsSub = _menuPool.AddSubMenu(menu, "Police Peds");
            for (int i = 0; i < 1; i++) ;

            PolicePedsSub.MouseEdgeEnabled = false;
            PolicePedsSub.ControlDisablingEnabled = false;
                
            var smycop = new UIMenuItem("LSPD Officer (Male)", "Changes your ped model to an LSPD Officer");
            PolicePedsSub.AddItem(smycop);
            PolicePedsSub.OnItemSelect += (sender, item, index) =>
            {
                if (item == smycop)
                {
                    Game.Player.ChangeModel("s_m_y_cop_01");
                    Screen.ShowSubtitle("Ped set to ~b~LSPD Officer");
                }
            };
            var sfycop = new UIMenuItem("LSPD Officer (Female)", "Changes your ped model to an LSPD Officer");
            PolicePedsSub.AddItem(sfycop);
            PolicePedsSub.OnItemSelect += (sender, item, index) =>
            {
                if (item == sfycop)
                {
                    Game.Player.ChangeModel("s_f_y_cop_01");
                    Screen.ShowSubtitle("Ped set to ~b~LSPD Officer (Female)");
                }
            };
            var smysheriff = new UIMenuItem("LSSD Sheriff (Male)", "Changes your ped model to an LSSD Sheriff");
            PolicePedsSub.AddItem(smysheriff);
            PolicePedsSub.OnItemSelect += (sender, item, index) =>
            {
                if (item == smysheriff)
                {
                    Game.Player.ChangeModel("s_m_y_sheriff_01");
                    Screen.ShowSubtitle("Ped set to ~b~LSSD Sheriff (Male)");
                }
            };
            var sfysheriff = new UIMenuItem("LSSD Sheriff (Female)", "Changes your ped model to an LSSD Sheriff");
            PolicePedsSub.AddItem(sfysheriff);
            PolicePedsSub.OnItemSelect += (sender, item, index) =>
            {
                if (item == sfysheriff)
                {
                    Game.Player.ChangeModel("s_f_y_sheriff_01");
                    Screen.ShowSubtitle("Ped set to ~b~LSSD Sheriff (Female)");
                }
            };
            var smyhwaycop = new UIMenuItem("SAHP Officer (Male)", "Changes your ped model to an SAHP Officer");
            PolicePedsSub.AddItem(smyhwaycop);
            PolicePedsSub.OnItemSelect += (sender, item, index) =>
            {
                if (item == smyhwaycop)
                {
                    Game.Player.ChangeModel("s_m_y_hwaycop_01");
                    Screen.ShowSubtitle("Ped set to ~b~SAHP Officer (Male)");
                }
            };
        }
            
        public MainMenu()
        {
            _menuPool    = new MenuPool();
            var mainMenu = new UIMenu("Ped Menu", "~r~v0.1 ALPHA ~b~(Asteroid Scripts)");
            _menuPool.Add(mainMenu);
                
            PolicePeds(mainMenu);

            _menuPool.MouseEdgeEnabled = false;
            _menuPool.ControlDisablingEnabled = false;
            _menuPool.RefreshIndex();

            Tick += async () =>
            {
                _menuPool.ProcessMenus();
                if (API.IsControlJustPressed(0, 166) && !_menuPool.IsAnyMenuOpen()) // Our menu on/off switch
                   mainMenu.Visible = !mainMenu.Visible;
            };
        }
    }
}