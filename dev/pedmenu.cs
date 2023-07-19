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
            var PolicePedsSub = _menuPool.AddSubMenu(menu, "Law Enforcement");
            for (int i = 0; i < 1; i++) ;

            PolicePedsSub.MouseEdgeEnabled = false;
            PolicePedsSub.ControlDisablingEnabled = false;
                
            var smycop = new UIMenuItem("LSPD Officer (Male)", "Changes your ped model to a Male LSPD Officer");
            PolicePedsSub.AddItem(smycop);
            PolicePedsSub.OnItemSelect += (sender, item, index) =>
            {
                if (item == smycop)
                {
                    Game.Player.ChangeModel("s_m_y_cop_01");
                    Screen.ShowSubtitle("Ped set to ~b~LSPD Officer (Male)");
                }
            };
            
            var sfycop = new UIMenuItem("LSPD Officer (Female)", "Changes your ped model to a Female LSPD Officer");
            PolicePedsSub.AddItem(sfycop);
            PolicePedsSub.OnItemSelect += (sender, item, index) =>
            {
                if (item == sfycop)
                {
                    Game.Player.ChangeModel("s_f_y_cop_01");
                    Screen.ShowSubtitle("Ped set to ~b~LSPD Officer (Female)");
                }
            };
            
            var smysheriff = new UIMenuItem("LSSD Sheriff (Male)", "Changes your ped model to a Male LSSD Sheriff");
            PolicePedsSub.AddItem(smysheriff);
            PolicePedsSub.OnItemSelect += (sender, item, index) =>
            {
                if (item == smysheriff)
                {
                    Game.Player.ChangeModel("s_m_y_sheriff_01");
                    Screen.ShowSubtitle("Ped set to ~b~LSSD Sheriff (Male)");
                }
            };
            
            var sfysheriff = new UIMenuItem("LSSD Sheriff (Female)", "Changes your ped model to a Female LSSD Sheriff");
            PolicePedsSub.AddItem(sfysheriff);
            PolicePedsSub.OnItemSelect += (sender, item, index) =>
            {
                if (item == sfysheriff)
                {
                    Game.Player.ChangeModel("s_f_y_sheriff_01");
                    Screen.ShowSubtitle("Ped set to ~b~LSSD Sheriff (Female)");
                }
            };
            
            var smyhwaycop = new UIMenuItem("SAHP Officer (Male)", "Changes your ped model to a Male SAHP Officer");
            PolicePedsSub.AddItem(smyhwaycop);
            PolicePedsSub.OnItemSelect += (sender, item, index) =>
            {
                if (item == smyhwaycop)
                {
                    Game.Player.ChangeModel("s_m_y_hwaycop_01");
                    Screen.ShowSubtitle("Ped set to ~b~SAHP Officer (Male)");
                }
            };
            
            var smyranger = new UIMenuItem("SASPR Ranger (Male)", "Changes your ped model to a Male SASPR Ranger");
            PolicePedsSub.AddItem(smyranger);
            PolicePedsSub.OnItemSelect += (sender, item, index) =>
            {
                if (item == smyranger)
                {
                    Game.Player.ChangeModel("s_m_y_ranger_01");
                    Screen.ShowSubtitle("Ped set to ~b~SASPR Ranger (Male)");
                }
            };
            
            var sfyranger = new UIMenuItem("SASPR Ranger (Female)", "Changes your ped model to a Female SASPR Ranger");
            PolicePedsSub.AddItem(sfyranger);
            PolicePedsSub.OnItemSelect += (sender, item, index) =>
            {
                if (item == sfyranger)
                {
                    Game.Player.ChangeModel("s_f_y_ranger_01");
                    Screen.ShowSubtitle("Ped set to ~b~SASPR Ranger (Female)");
                }
            };
            
            var smyswat = new UIMenuItem("LSPD Swat (Male)", "Changes your ped model to a Male LSPD Swat Officer");
            PolicePedsSub.AddItem(smyswat);
            PolicePedsSub.OnItemSelect += (sender, item, index) =>
            {
                if (item == smyswat)
                {
                    Game.Player.ChangeModel("s_m_y_swat_01");
                    Screen.ShowSubtitle("Ped set to ~b~LSPD Swat (Male)");
                }
            };
            
            var smmsnowcop = new UIMenuItem("NYSP Officer (Male)", "Changes your ped model to a Male NYSP Officer");
            PolicePedsSub.AddItem(smmsnowcop);
            PolicePedsSub.OnItemSelect += (sender, item, index) =>
            {
                if (item == smmsnowcop)
                {
                    Game.Player.ChangeModel("s_m_m_snowcop_01");
                    Screen.ShowSubtitle("Ped set to ~b~NYSP Officer (Male)");
                }
            };
            
            var smyuscg = new UIMenuItem("US Coast Guard (Male)", "Changes your ped model to a Male US Coast Guard");
            PolicePedsSub.AddItem(smyuscg);
            PolicePedsSub.OnItemSelect += (sender, item, index) =>
            {
                if (item == smyuscg)
                {
                    Game.Player.ChangeModel("s_m_y_uscg_01");
                    Screen.ShowSubtitle("Ped set to ~b~US Coast Guard (Male)");
                }
            };
            
            var smmsecurity = new UIMenuItem("Security Guard (Male)", "Changes your ped model to a Male Security Guard");
            PolicePedsSub.AddItem(smmsecurity);
            PolicePedsSub.OnItemSelect += (sender, item, index) =>
            {
                if (item == smmsecurity)
                {
                    Game.Player.ChangeModel("s_m_m_security_01");
                    Screen.ShowSubtitle("Ped set to ~b~Security Guard (Male)");
                }
            };
            
            var ummprolsec = new UIMenuItem("Security Guard 2 (Male)", "Changes your ped model to a Male Security Guard");
            PolicePedsSub.AddItem(ummprolsec);
            PolicePedsSub.OnItemSelect += (sender, item, index) =>
            {
                if (item == ummprolsec)
                {
                    Game.Player.ChangeModel("u_m_m_prolsec_01");
                    Screen.ShowSubtitle("Ped set to ~b~Security Guard 2 (Male)");
                }
            };
            
            var mpmsecuroguard = new UIMenuItem("Security Guard 3 (Male)", "Changes your ped model to a Male Security Guard");
            PolicePedsSub.AddItem(mpmsecuroguard);
            PolicePedsSub.OnItemSelect += (sender, item, index) =>
            {
                if (item == mpmsecuroguard)
                {
                    Game.Player.ChangeModel("mp_m_securoguard_01");
                    Screen.ShowSubtitle("Ped set to ~b~Security Guard 3 (Male)");
                }
            };
            
            var ummfibarchitect = new UIMenuItem("FIB Architect (Male)", "Changes your ped model to a Male FIB Architect");
            PolicePedsSub.AddItem(ummfibarchitect);
            PolicePedsSub.OnItemSelect += (sender, item, index) =>
            {
                if (item == ummfibarchitect)
                {
                    Game.Player.ChangeModel("u_m_m_fibarchitect");
                    Screen.ShowSubtitle("Ped set to ~b~FIB Architect (Male)");
                }
            };
            
            var espeds = _menuPool.AddSubMenu(menu, "Other Emergency Services");
            for (int i = 0; i < 1; i++) ;

            espeds.MouseEdgeEnabled        = false;
            espeds.ControlDisablingEnabled = false;
            
            var smyfireman = new UIMenuItem("Firefighter (Male)", "Changes your ped model to a Male Firefighter");
            espeds.AddItem(smyfireman);
            espeds.OnItemSelect += (sender, item, index) =>
            {
                if (item == smyfireman)
                {
                    Game.Player.ChangeModel("s_m_y_fireman_01");
                    Screen.ShowSubtitle("Ped set to ~b~Firefighter (Male)");
                }
            };
            
            var smmparamedic = new UIMenuItem("Paramedic (Male)", "Changes your ped model to a Male Paramedic");
            espeds.AddItem(smmparamedic);
            espeds.OnItemSelect += (sender, item, index) =>
            {
                if (item == smmparamedic)
                {
                    Game.Player.ChangeModel("s_m_m_paramedic_01");
                    Screen.ShowSubtitle("Ped set to ~b~Paramedic (Male)");
                }
            };
            
            var smybaywatch = new UIMenuItem("Lifeguard (Male)", "Changes your ped model to a Male Lifeguard");
            espeds.AddItem(smybaywatch);
            espeds.OnItemSelect += (sender, item, index) =>
            {
                if (item == smybaywatch)
                {
                    Game.Player.ChangeModel("s_m_y_baywatch_01");
                    Screen.ShowSubtitle("Ped set to ~b~Lifeguard (Male)");
                }
            };
            
            var ambientmale = _menuPool.AddSubMenu(menu, "Ambient Males");
            for (int i = 0; i < 1; i++) ;

            ambientmale.MouseEdgeEnabled = false;
            ambientmale.ControlDisablingEnabled = false;
            
            var ammacult = new UIMenuItem("Cult", "Changes your ped model to a Cult Male");
            ambientmale.AddItem(ammacult);
            ambientmale.OnItemSelect += (sender, item, index) =>
            {
                if (item == ammacult)
                {
                    Game.Player.ChangeModel("a_m_m_acult_01");
                    Screen.ShowSubtitle("Ped set to ~b~Cult (Male)");
                }
            };
            
            var amyepsilon = new UIMenuItem("Cult 2", "Changes your ped model to a Cult Male");
            ambientmale.AddItem(amyepsilon);
            ambientmale.OnItemSelect += (sender, item, index) =>
            {
                if (item == amyepsilon)
                {
                    Game.Player.ChangeModel("a_m_y_epsilon_01");
                    Screen.ShowSubtitle("Ped set to ~b~Cult 2 (Male)");
                }
            };
            
            var amyepsilon2 = new UIMenuItem("Cult 3", "Changes your ped model to a Cult Male");
            ambientmale.AddItem(amyepsilon2);
            ambientmale.OnItemSelect += (sender, item, index) =>
            {
                if (item == amyepsilon2)
                {
                    Game.Player.ChangeModel("a_m_y_epsilon_02");
                    Screen.ShowSubtitle("Ped set to ~b~Cult 3 (Male)");
                }
            };
            
            var ammbeach = new UIMenuItem("Beach 1", "Changes your ped model to a Beach Male");
            ambientmale.AddItem(ammbeach);
            ambientmale.OnItemSelect += (sender, item, index) =>
            {
                if (item == ammbeach)
                {
                    Game.Player.ChangeModel("a_m_m_beach_01");
                    Screen.ShowSubtitle("Ped set to ~b~Beach 1 (Male)");
                }
            };
            
            var ammbeach2 = new UIMenuItem("Beach 2", "Changes your ped model to a Beach Male");
            ambientmale.AddItem(ammbeach2);
            ambientmale.OnItemSelect += (sender, item, index) =>
            {
                if (item == ammbeach2)
                {
                    Game.Player.ChangeModel("a_m_m_beach_02");
                    Screen.ShowSubtitle("Ped set to ~b~Beach 2 (Male)");
                }
            };
            
            var ammbevhills = new UIMenuItem("Beverly Hills 1", "Changes your ped model to a Beverly Hills Male");
            ambientmale.AddItem(ammbevhills);
            ambientmale.OnItemSelect += (sender, item, index) =>
            {
                if (item == ammbevhills)
                {
                    Game.Player.ChangeModel("a_m_m_bevhills_01");
                    Screen.ShowSubtitle("Ped set to ~b~Beverly Hills 1 (Male)");
                }
            };
            
            var ammbevhills2 = new UIMenuItem("Beverly Hills 2", "Changes your ped model to a Beverly Hills Male");
            ambientmale.AddItem(ammbevhills2);
            ambientmale.OnItemSelect += (sender, item, index) =>
            {
                if (item == ammbevhills2)
                {
                    Game.Player.ChangeModel("a_m_m_bevhills_02");
                    Screen.ShowSubtitle("Ped set to ~b~Beverly Hills 2 (Male)");
                }
            };
            
            var amybevhills = new UIMenuItem("Beverly Hills 3", "Changes your ped model to a Beverly Hills Male");
            ambientmale.AddItem(amybevhills);
            ambientmale.OnItemSelect += (sender, item, index) =>
            {
                if (item == amybevhills)
                {
                    Game.Player.ChangeModel("a_m_y_bevhills_01");
                    Screen.ShowSubtitle("Ped set to ~b~Beverly Hills 3 (Male)");
                }
            };
            
            var amybevhills2 = new UIMenuItem("Beverly Hills 4", "Changes your ped model to a Beverly Hills Male");
            ambientmale.AddItem(amybevhills2);
            ambientmale.OnItemSelect += (sender, item, index) =>
            {
                if (item == amybevhills2)
                {
                    Game.Player.ChangeModel("a_m_y_bevhills_02");
                    Screen.ShowSubtitle("Ped set to ~b~Beverly Hills 4 (Male)");
                }
            };
            
            var ammbusiness = new UIMenuItem("Businessman", "Changes your ped model to a Businessman");
            ambientmale.AddItem(ammbusiness);
            ambientmale.OnItemSelect += (sender, item, index) =>
            {
                if (item == ammbusiness)
                {
                    Game.Player.ChangeModel("a_m_m_business_01");
                    Screen.ShowSubtitle("Ped set to ~b~Business (Male)");
                }
            };
            
            var ammfarmer = new UIMenuItem("Farmer", "Changes your ped model to a Farmer");
            ambientmale.AddItem(ammfarmer);
            ambientmale.OnItemSelect += (sender, item, index) =>
            {
                if (item == ammfarmer)
                {
                    Game.Player.ChangeModel("a_m_m_farmer_01");
                    Screen.ShowSubtitle("Ped set to ~b~Farmer (Male)");
                }
            };
            
            var ammhillbilly = new UIMenuItem("Hillbilly 1", "Changes your ped model to a Hillbilly");
            ambientmale.AddItem(ammhillbilly);
            ambientmale.OnItemSelect += (sender, item, index) =>
            {
                if (item == ammhillbilly)
                {
                    Game.Player.ChangeModel("a_m_m_hillbilly_01");
                    Screen.ShowSubtitle("Ped set to ~b~Hillbilly (Male)");
                }
            };
            
            var ammhillbilly2 = new UIMenuItem("Hillbilly 2", "Changes your ped model to a Hillbilly");
            ambientmale.AddItem(ammhillbilly2);
            ambientmale.OnItemSelect += (sender, item, index) =>
            {
                if (item == ammhillbilly2)
                {
                    Game.Player.ChangeModel("a_m_m_hillbilly_02");
                    Screen.ShowSubtitle("Ped set to ~b~Hillbilly (Male)");
                }
            };
            
            var ammogboss = new UIMenuItem("OG Boss", "Changes your ped model to an OG Boss");
            ambientmale.AddItem(ammogboss);
            ambientmale.OnItemSelect += (sender, item, index) =>
            {
                if (item == ammogboss)
                {
                    Game.Player.ChangeModel("a_m_m_og_boss_01");
                    Screen.ShowSubtitle("Ped set to ~b~OG Boss (Male)");
                }
            };
            
            var ammpaparazzi = new UIMenuItem("Paparazzi", "Changes your ped model to a Paparazzi");
            ambientmale.AddItem(ammpaparazzi);
            ambientmale.OnItemSelect += (sender, item, index) =>
            {
                if (item == ammpaparazzi)
                {
                    Game.Player.ChangeModel("a_m_m_paparazzi_01");
                    Screen.ShowSubtitle("Ped set to ~b~Paparazzi (Male)");
                }
            };
            
            var ammtourist = new UIMenuItem("Tourist", "Changes your ped model to a Tourist");
            ambientmale.AddItem(ammtourist);
            ambientmale.OnItemSelect += (sender, item, index) =>
            {
                if (item == ammtourist)
                {
                    Game.Player.ChangeModel("a_m_m_paparazzi_01");
                    Screen.ShowSubtitle("Ped set to ~b~Tourist (Male)");
                }
            };
            
            var ambientfemale = _menuPool.AddSubMenu(menu, "Ambient Females");
            for (int i = 0; i < 1; i++) ;

            ambientfemale.MouseEdgeEnabled        = false;
            ambientfemale.ControlDisablingEnabled = false;
            
            var afmbeach = new UIMenuItem("Beach", "Changes your ped model to a Beach");
            ambientfemale.AddItem(afmbeach);
            ambientfemale.OnItemSelect += (sender, item, index) =>
            {
                if (item == afmbeach)
                {
                    Game.Player.ChangeModel("a_f_m_beach_01");
                    Screen.ShowSubtitle("Ped set to ~b~Beach (Female)");
                }
            };
            
            var afmbevhills = new UIMenuItem("Beverly Hills 1", "Changes your ped model to a Beverly Hills");
            ambientfemale.AddItem(afmbevhills);
            ambientfemale.OnItemSelect += (sender, item, index) =>
            {
                if (item == afmbevhills)
                {
                    Game.Player.ChangeModel("a_f_m_bevhills_01");
                    Screen.ShowSubtitle("Ped set to ~b~Beverly Hills 1 (Female)");
                }
            };
            
            var afmbevhills2 = new UIMenuItem("Beverly Hills 2", "Changes your ped model to a Beverly Hills");
            ambientfemale.AddItem(afmbevhills2);
            ambientfemale.OnItemSelect += (sender, item, index) =>
            {
                if (item == afmbevhills2)
                {
                    Game.Player.ChangeModel("a_f_m_bevhills_02");
                    Screen.ShowSubtitle("Ped set to ~b~Beverly Hills 2 (Female)");
                }
            };
            
            var afmbusiness = new UIMenuItem("Businesswoman", "Changes your ped model to a Businesswoman");
            ambientfemale.AddItem(afmbusiness);
            ambientfemale.OnItemSelect += (sender, item, index) =>
            {
                if (item == afmbusiness)
                {
                    Game.Player.ChangeModel("a_f_m_business_02");
                    Screen.ShowSubtitle("Ped set to ~b~Business (Female)");
                }
            };
            
            var afmfatcult = new UIMenuItem("Fat Cult", "Changes your ped model to a Fat Cult");
            ambientfemale.AddItem(afmfatcult);
            ambientfemale.OnItemSelect += (sender, item, index) =>
            {
                if (item == afmfatcult)
                {
                    Game.Player.ChangeModel("a_f_m_fatcult_01");
                    Screen.ShowSubtitle("Ped set to ~b~Fat Cult (Female)");
                }
            };
            
            var afmtourist = new UIMenuItem("Tourist", "Changes your ped model to a Tourist");
            ambientfemale.AddItem(afmtourist);
            ambientfemale.OnItemSelect += (sender, item, index) =>
            {
                if (item == afmtourist)
                {
                    Game.Player.ChangeModel("a_f_m_tourist_01");
                    Screen.ShowSubtitle("Ped set to ~b~Tourist (Female)");
                }
            };
            
            var afmtramp = new UIMenuItem("Tramp", "Changes your ped model to a Tramp");
            ambientfemale.AddItem(afmtramp);
            ambientfemale.OnItemSelect += (sender, item, index) =>
            {
                if (item == afmtramp)
                {
                    Game.Player.ChangeModel("a_f_m_tramp_01");
                    Screen.ShowSubtitle("Ped set to ~b~Tramp (Female)");
                }
            };
            
            var afybevhills = new UIMenuItem("Beverly Hills 1", "Changes your ped model to a Beverly Hills");
            ambientfemale.AddItem(afybevhills);
            ambientfemale.OnItemSelect += (sender, item, index) =>
            {
                if (item == afybevhills)
                {
                    Game.Player.ChangeModel("a_f_y_bevhills_01");
                    Screen.ShowSubtitle("Ped set to ~b~Beverly Hills 1 (Female)");
                }
            };
            
            var afybevhills2 = new UIMenuItem("Beverly Hills 2", "Changes your ped model to a Beverly Hills");
            ambientfemale.AddItem(afybevhills2);
            ambientfemale.OnItemSelect += (sender, item, index) =>
            {
                if (item == afybevhills2)
                {
                    Game.Player.ChangeModel("a_f_y_bevhills_02");
                    Screen.ShowSubtitle("Ped set to ~b~Beverly Hills 2 (Female)");
                }
            };
            
            var afybevhills3 = new UIMenuItem("Beverly Hills 3", "Changes your ped model to a Beverly Hills");
            ambientfemale.AddItem(afybevhills3);
            ambientfemale.OnItemSelect += (sender, item, index) =>
            {
                if (item == afybevhills3)
                {
                    Game.Player.ChangeModel("a_f_y_bevhills_03");
                    Screen.ShowSubtitle("Ped set to ~b~Beverly Hills 3 (Female)");
                }
            };
            
            var afybevhills4 = new UIMenuItem("Beverly Hills 4", "Changes your ped model to a Beverly Hills");
            ambientfemale.AddItem(afybevhills4);
            ambientfemale.OnItemSelect += (sender, item, index) =>
            {
                if (item == afybevhills4)
                {
                    Game.Player.ChangeModel("a_f_y_bevhills_04");
                    Screen.ShowSubtitle("Ped set to ~b~Beverly Hills 4 (Female)");
                }
            };
            
            var afyvinewood = new UIMenuItem("Vinewood 1", "Changes your ped model to Vinewood");
            ambientfemale.AddItem(afyvinewood);
            ambientfemale.OnItemSelect += (sender, item, index) =>
            {
                if (item == afyvinewood)
                {
                    Game.Player.ChangeModel("a_f_y_vinewood_01");
                    Screen.ShowSubtitle("Ped set to ~b~Vinewood 1 (Female)");
                }
            };
            
            var afyvinewood2 = new UIMenuItem("Vinewood 2", "Changes your ped model to Vinewood");
            ambientfemale.AddItem(afyvinewood2);
            ambientfemale.OnItemSelect += (sender, item, index) =>
            {
                if (item == afyvinewood2)
                {
                    Game.Player.ChangeModel("a_f_y_vinewood_02");
                    Screen.ShowSubtitle("Ped set to ~b~Vinewood 2 (Female)");
                }
            };
            
            var afyvinewood3 = new UIMenuItem("Vinewood 3", "Changes your ped model to Vinewood");
            ambientfemale.AddItem(afyvinewood3);
            ambientfemale.OnItemSelect += (sender, item, index) =>
            {
                if (item == afyvinewood3)
                {
                    Game.Player.ChangeModel("a_f_y_vinewood_03");
                    Screen.ShowSubtitle("Ped set to ~b~Vinewood 3 (Female)");
                }
            };
            
            var afyvinewood4 = new UIMenuItem("Vinewood 4", "Changes your ped model to Vinewood");
            ambientfemale.AddItem(afyvinewood4);
            ambientfemale.OnItemSelect += (sender, item, index) =>
            {
                if (item == afyvinewood4)
                {
                    Game.Player.ChangeModel("a_f_y_vinewood_04");
                    Screen.ShowSubtitle("Ped set to ~b~Vinewood 4 (Female)");
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