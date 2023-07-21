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
            
            var smmsecurity = new UIMenuItem("Security Guard 1 (Male)", "Changes your ped model to a Male Security Guard");
            PolicePedsSub.AddItem(smmsecurity);
            PolicePedsSub.OnItemSelect += (sender, item, index) =>
            {
                if (item == smmsecurity)
                {
                    Game.Player.ChangeModel("s_m_m_security_01");
                    Screen.ShowSubtitle("Ped set to ~b~Security Guard (Male)");
                }
            };
            
            var ummprolsec = new UIMenuItem("Security Guard 2 (Male) ~r~EXPLICIT", "Changes your ped model to a Male Security Guard");
            PolicePedsSub.AddItem(ummprolsec);
            PolicePedsSub.OnItemSelect += (sender, item, index) =>
            {
                if (item == ummprolsec)
                {
                    Game.Player.ChangeModel("u_m_m_prolsec_01");
                    Screen.ShowSubtitle("Ped set to ~b~Security Guard 2 (Male)");
                }
            };
            
            var csprolsec = new UIMenuItem("Security Guard 3 (Male)", "Changes your ped model to a Male Security Guard");
            PolicePedsSub.AddItem(csprolsec);
            PolicePedsSub.OnItemSelect += (sender, item, index) =>
            {
                if (item == csprolsec)
                {
                    Game.Player.ChangeModel("cs_prolsec_02");
                    Screen.ShowSubtitle("Ped set to ~b~Security Guard 3 (Male)");
                }
            };
            
            var mpmsecuroguard = new UIMenuItem("Security Guard 4 (Male)", "Changes your ped model to a Male Security Guard");
            PolicePedsSub.AddItem(mpmsecuroguard);
            PolicePedsSub.OnItemSelect += (sender, item, index) =>
            {
                if (item == mpmsecuroguard)
                {
                    Game.Player.ChangeModel("mp_m_securoguard_01");
                    Screen.ShowSubtitle("Ped set to ~b~Security Guard 4 (Male)");
                }
            };
            
            var csbprolsec = new UIMenuItem("Security Guard 5 (Male)", "Changes your ped model to a Male Security Guard");
            PolicePedsSub.AddItem(csbprolsec);
            PolicePedsSub.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbprolsec)
                {
                    Game.Player.ChangeModel("csb_prolsec");
                    Screen.ShowSubtitle("Ped set to ~b~Security Guard 5 (Male)");
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
            
            var csbtrafficwarden = new UIMenuItem("Traffic Warden (Male)", "Changes your ped model to a Male Traffic Warden");
            PolicePedsSub.AddItem(csbtrafficwarden);
            PolicePedsSub.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbtrafficwarden)
                {
                    Game.Player.ChangeModel("csb_trafficwarden");
                    Screen.ShowSubtitle("Ped set to ~b~Traffic Warden (Male)");
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
            
            var ammacult = new UIMenuItem("Cult 1 ~r~EXPLICIT", "Changes your ped model to a Cult Male");
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
            
            var ammbusiness = new UIMenuItem("Business", "Changes your ped model to a Businessman");
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
                    Game.Player.ChangeModel("a_m_m_tourist_01");
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
            
            var afmbusiness = new UIMenuItem("Business 1", "Changes your ped model to a Businesswoman");
            ambientfemale.AddItem(afmbusiness);
            ambientfemale.OnItemSelect += (sender, item, index) =>
            {
                if (item == afmbusiness)
                {
                    Game.Player.ChangeModel("a_f_m_business_02");
                    Screen.ShowSubtitle("Ped set to ~b~Business (Female)");
                }
            };
            
            var afybusiness = new UIMenuItem("Business 2", "Changes your ped model to a Businesswoman");
            ambientfemale.AddItem(afybusiness);
            ambientfemale.OnItemSelect += (sender, item, index) =>
            {
                if (item == afybusiness)
                {
                    Game.Player.ChangeModel("a_f_y_business_01");
                    Screen.ShowSubtitle("Ped set to ~b~Business (Female)");
                }
            };
            
            var afybusiness2 = new UIMenuItem("Business 3", "Changes your ped model to a Businesswoman");
            ambientfemale.AddItem(afybusiness2);
            ambientfemale.OnItemSelect += (sender, item, index) =>
            {
                if (item == afybusiness2)
                {
                    Game.Player.ChangeModel("a_f_y_business_02");
                    Screen.ShowSubtitle("Ped set to ~b~Business (Female)");
                }
            };
            
            var afybusiness3 = new UIMenuItem("Business 4", "Changes your ped model to a Businesswoman");
            ambientfemale.AddItem(afybusiness3);
            ambientfemale.OnItemSelect += (sender, item, index) =>
            {
                if (item == afybusiness2)
                {
                    Game.Player.ChangeModel("a_f_y_business_03");
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
            
            var animals = _menuPool.AddSubMenu(menu, "Animals");
            for (int i = 0; i < 1; i++) ;

            animals.MouseEdgeEnabled = false;
            animals.ControlDisablingEnabled = false;
            
            var acboar = new UIMenuItem("Boar", "Changes your ped model to a boar");
            animals.AddItem(acboar);
            animals.OnItemSelect += (sender, item, index) =>
            {
                if (item == acboar)
                {
                    Game.Player.ChangeModel("a_c_boar");
                    Screen.ShowSubtitle("Ped set to ~b~Boar");
                }
            };
            
            var accat = new UIMenuItem("Cat", "Changes your ped model to a cat");
            animals.AddItem(accat);
            animals.OnItemSelect += (sender, item, index) =>
            {
                if (item == accat)
                {
                    Game.Player.ChangeModel("a_c_cat_01");
                    Screen.ShowSubtitle("Ped set to ~b~Cat");
                }
            };
            
            var acchickenhawk = new UIMenuItem("Hawk", "Changes your ped model to a hawk");
            animals.AddItem(acchickenhawk);
            animals.OnItemSelect += (sender, item, index) =>
            {
                if (item == acchickenhawk)
                {
                    Game.Player.ChangeModel("a_c_chickenhawk");
                    Screen.ShowSubtitle("Ped set to ~b~Hawk");
                }
            };
            
            var acchimp = new UIMenuItem("Chimp", "Changes your ped model to a chimp");
            animals.AddItem(acchimp);
            animals.OnItemSelect += (sender, item, index) =>
            {
                if (item == acchimp)
                {
                    Game.Player.ChangeModel("a_c_chimp");
                    Screen.ShowSubtitle("Ped set to ~b~Chimp");
                }
            };
            
            var accormorant = new UIMenuItem("Cormorant", "Changes your ped model to cormorant");
            animals.AddItem(accormorant);
            animals.OnItemSelect += (sender, item, index) =>
            {
                if (item == accormorant)
                {
                    Game.Player.ChangeModel("a_c_cormorant");
                    Screen.ShowSubtitle("Ped set to ~b~Cormorant");
                }
            };
            
            var accow = new UIMenuItem("Cow", "Changes your ped model to cow");
            animals.AddItem(accow);
            animals.OnItemSelect += (sender, item, index) =>
            {
                if (item == accow)
                {
                    Game.Player.ChangeModel("a_c_cow");
                    Screen.ShowSubtitle("Ped set to ~b~Cow");
                }
            };
            
            var accoyote = new UIMenuItem("Coyote", "Changes your ped model to a coyote");
            animals.AddItem(accoyote);
            animals.OnItemSelect += (sender, item, index) =>
            {
                if (item == accoyote)
                {
                    Game.Player.ChangeModel("a_c_coyote");
                    Screen.ShowSubtitle("Ped set to ~b~Coyote");
                }
            };
            
            var accrow = new UIMenuItem("Crow", "Changes your ped model to a crow");
            animals.AddItem(accrow);
            animals.OnItemSelect += (sender, item, index) =>
            {
                if (item == accrow)
                {
                    Game.Player.ChangeModel("a_c_crow");
                    Screen.ShowSubtitle("Ped set to ~b~Crow");
                }
            };
            
            var acdeer = new UIMenuItem("Deer", "Changes your ped model to a deer");
            animals.AddItem(acdeer);
            animals.OnItemSelect += (sender, item, index) =>
            {
                if (item == acdeer)
                {
                    Game.Player.ChangeModel("a_c_deer");
                    Screen.ShowSubtitle("Ped set to ~b~Deer");
                }
            };
            
            var acdolphin = new UIMenuItem("Dolphin", "Changes your ped model to a dolphin");
            animals.AddItem(acdolphin);
            animals.OnItemSelect += (sender, item, index) =>
            {
                if (item == acdolphin)
                {
                    Game.Player.ChangeModel("a_c_dolphin");
                    Screen.ShowSubtitle("Ped set to ~b~Dolphin");
                }
            };
            
            var acfish = new UIMenuItem("Fish", "Changes your ped model to a fish");
            animals.AddItem(acfish);
            animals.OnItemSelect += (sender, item, index) =>
            {
                if (item == acfish)
                {
                    Game.Player.ChangeModel("a_c_fish");
                    Screen.ShowSubtitle("Ped set to ~b~Fish");
                }
            };
            
            var achen = new UIMenuItem("Hen", "Changes your ped model to a hen");
            animals.AddItem(achen);
            animals.OnItemSelect += (sender, item, index) =>
            {
                if (item == achen)
                {
                    Game.Player.ChangeModel("a_c_hen");
                    Screen.ShowSubtitle("Ped set to ~b~Hen");
                }
            };
            
            var achumpback = new UIMenuItem("Humpback", "Changes your ped model to a humpback");
            animals.AddItem(achumpback);
            animals.OnItemSelect += (sender, item, index) =>
            {
                if (item == achumpback)
                {
                    Game.Player.ChangeModel("a_c_humpback");
                    Screen.ShowSubtitle("Ped set to ~b~Humpback");
                }
            };
            
            var ackillerwhale = new UIMenuItem("Killer Whale", "Changes your ped model to a killer whale");
            animals.AddItem(ackillerwhale);
            animals.OnItemSelect += (sender, item, index) =>
            {
                if (item == ackillerwhale)
                {
                    Game.Player.ChangeModel("a_c_killerwhale");
                    Screen.ShowSubtitle("Ped set to ~b~Killer Whale");
                }
            };
            
            var acpig = new UIMenuItem("Pig", "Changes your ped model to a pig");
            animals.AddItem(acpig);
            animals.OnItemSelect += (sender, item, index) =>
            {
                if (item == acpig)
                {
                    Game.Player.ChangeModel("a_c_pig");
                    Screen.ShowSubtitle("Ped set to ~b~Pig");
                }
            };
            
            var acpigeon = new UIMenuItem("Pigeon", "Changes your ped model to a pigeon");
            animals.AddItem(acpigeon);
            animals.OnItemSelect += (sender, item, index) =>
            {
                if (item == acpigeon)
                {
                    Game.Player.ChangeModel("a_c_pigeon");
                    Screen.ShowSubtitle("Ped set to ~b~Pigeon");
                }
            };
            
            var acpoodle = new UIMenuItem("Poodle", "Changes your ped model to a poodle");
            animals.AddItem(acpoodle);
            animals.OnItemSelect += (sender, item, index) =>
            {
                if (item == acpoodle)
                {
                    Game.Player.ChangeModel("a_c_poodle");
                    Screen.ShowSubtitle("Ped set to ~b~Poodle");
                }
            };
            
            var acpug = new UIMenuItem("Pug", "Changes your ped model to a pug");
            animals.AddItem(acpug);
            animals.OnItemSelect += (sender, item, index) =>
            {
                if (item == acpug)
                {
                    Game.Player.ChangeModel("a_c_pug");
                    Screen.ShowSubtitle("Ped set to ~b~Pug");
                }
            };
            
            var acrabbit = new UIMenuItem("Rabbit", "Changes your ped model to a rabbit");
            animals.AddItem(acrabbit);
            animals.OnItemSelect += (sender, item, index) =>
            {
                if (item == acrabbit)
                {
                    Game.Player.ChangeModel("a_c_rabbit_01");
                    Screen.ShowSubtitle("Ped set to ~b~Rabbit");
                }
            };
            
            var acrat = new UIMenuItem("Rat", "Changes your ped model to a rat");
            animals.AddItem(acrat);
            animals.OnItemSelect += (sender, item, index) =>
            {
                if (item == acrat)
                {
                    Game.Player.ChangeModel("a_c_rat");
                    Screen.ShowSubtitle("Ped set to ~b~Rat");
                }
            };
            
            var acrhesus = new UIMenuItem("Rhesus", "Changes your ped model to a rhesus");
            animals.AddItem(acrhesus);
            animals.OnItemSelect += (sender, item, index) =>
            {
                if (item == acrhesus)
                {
                    Game.Player.ChangeModel("a_c_rhesus");
                    Screen.ShowSubtitle("Ped set to ~b~Rhesus");
                }
            };
            
            var acseagull = new UIMenuItem("Seagull", "Changes your ped model to a seagull");
            animals.AddItem(acseagull);
            animals.OnItemSelect += (sender, item, index) =>
            {
                if (item == acseagull)
                {
                    Game.Player.ChangeModel("a_c_seagull");
                    Screen.ShowSubtitle("Ped set to ~b~Seagull");
                }
            };
            
            var acsharkhammer = new UIMenuItem("Hammerhead Shark", "Changes your ped model to a hammerhead shark");
            animals.AddItem(acsharkhammer);
            animals.OnItemSelect += (sender, item, index) =>
            {
                if (item == acsharkhammer)
                {
                    Game.Player.ChangeModel("a_c_sharkhammer");
                    Screen.ShowSubtitle("Ped set to ~b~Hammerhead Shark");
                }
            };
            
            var acsharktiger = new UIMenuItem("Tiger Shark", "Changes your ped model to a tiger shark");
            animals.AddItem(acsharktiger);
            animals.OnItemSelect += (sender, item, index) =>
            {
                if (item == acsharktiger)
                {
                    Game.Player.ChangeModel("a_c_sharktiger");
                    Screen.ShowSubtitle("Ped set to ~b~Tiger Shark");
                }
            };
            
            var acstingray = new UIMenuItem("Stingray", "Changes your ped model to a stingray");
            animals.AddItem(acstingray);
            animals.OnItemSelect += (sender, item, index) =>
            {
                if (item == acstingray)
                {
                    Game.Player.ChangeModel("a_c_stingray");
                    Screen.ShowSubtitle("Ped set to ~b~Stingray");
                }
            };
            
            var acwesty = new UIMenuItem("Westy", "Changes your ped model to a westy");
            animals.AddItem(acwesty);
            animals.OnItemSelect += (sender, item, index) =>
            {
                if (item == acwesty)
                {
                    Game.Player.ChangeModel("a_c_westy");
                    Screen.ShowSubtitle("Ped set to ~b~Westy");
                }
            };
            
            var cutscene = _menuPool.AddSubMenu(menu, "Cutscene Models");
            for (int i = 0; i < 1; i++) ;

            cutscene.MouseEdgeEnabled = false;
            cutscene.ControlDisablingEnabled = false;
            
            var csamandatownley = new UIMenuItem("Amanda", "Changes your ped model to Amanda");
            cutscene.AddItem(csamandatownley);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csamandatownley)
                {
                    Game.Player.ChangeModel("cs_amandatownley");
                    Screen.ShowSubtitle("Ped set to ~b~Amanda");
                }
            };
            
            var csandreas = new UIMenuItem("Andreas", "Changes your ped model to Andreas");
            cutscene.AddItem(csandreas);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csandreas)
                {
                    Game.Player.ChangeModel("cs_amandatownley");
                    Screen.ShowSubtitle("Ped set to ~b~Andreas");
                }
            };
            
            var csashley = new UIMenuItem("Ashley", "Changes your ped model to Ashley");
            cutscene.AddItem(csashley);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csashley)
                {
                    Game.Player.ChangeModel("cs_ashley");
                    Screen.ShowSubtitle("Ped set to ~b~Ashley");
                }
            };
            
            var csbankman = new UIMenuItem("Bankman", "Changes your ped model to Bankman");
            cutscene.AddItem(csbankman);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbankman)
                {
                    Game.Player.ChangeModel("cs_bankman");
                    Screen.ShowSubtitle("Ped set to ~b~Bankman");
                }
            };
            
            var csbarry = new UIMenuItem("Barry", "Changes your ped model to Barry");
            cutscene.AddItem(csbarry);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbarry)
                {
                    Game.Player.ChangeModel("cs_barry");
                    Screen.ShowSubtitle("Ped set to ~b~Barry");
                }
            };
            
            var csbeverly = new UIMenuItem("Beverly", "Changes your ped model to Beverly");
            cutscene.AddItem(csbeverly);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbeverly)
                {
                    Game.Player.ChangeModel("cs_beverly");
                    Screen.ShowSubtitle("Ped set to ~b~Beverly");
                }
            };
            
            var csbrad = new UIMenuItem("Brad", "Changes your ped model to Brad");
            cutscene.AddItem(csbrad);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbrad)
                {
                    Game.Player.ChangeModel("cs_brad");
                    Screen.ShowSubtitle("Ped set to ~b~Brad");
                }
            };
            
            var csbradcadaver = new UIMenuItem("Brad Cadaver", "Changes your ped model to Brad Cadaver");
            cutscene.AddItem(csbradcadaver);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbradcadaver)
                {
                    Game.Player.ChangeModel("cs_bradcadaver");
                    Screen.ShowSubtitle("Ped set to ~b~Brad Cadaver");
                }
            };
            
            var cscarbuyer = new UIMenuItem("Car Buyer", "Changes your ped model to Car Buyer");
            cutscene.AddItem(cscarbuyer);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == cscarbuyer)
                {
                    Game.Player.ChangeModel("cs_carbuyer");
                    Screen.ShowSubtitle("Ped set to ~b~Car Buyer");
                }
            };
            
            var cscasey = new UIMenuItem("Casey", "Changes your ped model to Casey");
            cutscene.AddItem(cscasey);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == cscasey)
                {
                    Game.Player.ChangeModel("cs_casey");
                    Screen.ShowSubtitle("Ped set to ~b~Casey");
                }
            };
            
            var cschengsr = new UIMenuItem("Cheng Senior", "Changes your ped model to Cheng Senior");
            cutscene.AddItem(cschengsr);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == cschengsr)
                {
                    Game.Player.ChangeModel("cs_chengsr");
                    Screen.ShowSubtitle("Ped set to ~b~Cheng Senior");
                }
            };
            
            var cschrisformage = new UIMenuItem("Chris Formage", "Changes your ped model to Chris Formage");
            cutscene.AddItem(cschrisformage);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == cschrisformage)
                {
                    Game.Player.ChangeModel("cs_chrisformage");
                    Screen.ShowSubtitle("Ped set to ~b~Chris Formage");
                }
            };
            
            var csclay = new UIMenuItem("Clay", "Changes your ped model to Clay");
            cutscene.AddItem(csclay);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csclay)
                {
                    Game.Player.ChangeModel("cs_clay");
                    Screen.ShowSubtitle("Ped set to ~b~Clay");
                }
            };
            
            var csdale = new UIMenuItem("Dale", "Changes your ped model to Dale");
            cutscene.AddItem(csdale);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csdale)
                {
                    Game.Player.ChangeModel("cs_dale");
                    Screen.ShowSubtitle("Ped set to ~b~Dale");
                }
            };
            
            var csdavenorton = new UIMenuItem("Dave Norton", "Changes your ped model to Dave Norton");
            cutscene.AddItem(csdavenorton);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csdavenorton)
                {
                    Game.Player.ChangeModel("cs_davenorton");
                    Screen.ShowSubtitle("Ped set to ~b~Dave Norton");
                }
            };
            
            var csdebra = new UIMenuItem("Debra", "Changes your ped model to Debra");
            cutscene.AddItem(csdebra);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csdebra)
                {
                    Game.Player.ChangeModel("cs_debra");
                    Screen.ShowSubtitle("Ped set to ~b~Debra");
                }
            };
            
            var csdenise = new UIMenuItem("Denise", "Changes your ped model to Denise");
            cutscene.AddItem(csdenise);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csdenise)
                {
                    Game.Player.ChangeModel("cs_denise");
                    Screen.ShowSubtitle("Ped set to ~b~Denise");
                }
            };
            
            var csdevin = new UIMenuItem("Devin", "Changes your ped model to Devin");
            cutscene.AddItem(csdevin);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csdevin)
                {
                    Game.Player.ChangeModel("cs_devin");
                    Screen.ShowSubtitle("Ped set to ~b~Devin");
                }
            };
            
            var csdom = new UIMenuItem("Dom", "Changes your ped model to Dom");
            cutscene.AddItem(csdom);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csdom)
                {
                    Game.Player.ChangeModel("cs_dom");
                    Screen.ShowSubtitle("Ped set to ~b~Dom");
                }
            };
            
            var cs_drfriedlander = new UIMenuItem("Dr. Friedlander", "Changes your ped model to Dr. Friedlander");
            cutscene.AddItem(csdreyfuse);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == cs_drfriedlander)
                {
                    Game.Player.ChangeModel("cs_drfriedlander");
                    Screen.ShowSubtitle("Ped set to ~b~Dr. Friedlander");
                }
            };
            
            var csdreyfuse = new UIMenuItem("Drey Fuse", "Changes your ped model to Drey Fuse");
            cutscene.AddItem(csdreyfuse);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csdreyfuse)
                {
                    Game.Player.ChangeModel("cs_dreyfuse");
                    Screen.ShowSubtitle("Ped set to ~b~Drey Fuse");
                }
            };
            
            var csfabien = new UIMenuItem("Fabien", "Changes your ped model to Fabien");
            cutscene.AddItem(csfabien);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csfabien)
                {
                    Game.Player.ChangeModel("cs_fabien");
                    Screen.ShowSubtitle("Ped set to ~b~Fabien");
                }
            };
            
            var csfloyd = new UIMenuItem("Floyd", "Changes your ped model to Floyd");
            cutscene.AddItem(csfloyd);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csfloyd)
                {
                    Game.Player.ChangeModel("cs_floyd");
                    Screen.ShowSubtitle("Ped set to ~b~Floyd");
                }
            };
            
            var csguadalope = new UIMenuItem("Guadalope", "Changes your ped model to Guadalope");
            cutscene.AddItem(csguadalope);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csguadalope)
                {
                    Game.Player.ChangeModel("cs_guadalope");
                    Screen.ShowSubtitle("Ped set to ~b~Guadalope");
                }
            };
            
            var csgurk = new UIMenuItem("Gurk", "Changes your ped model to Gurk");
            cutscene.AddItem(csgurk);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csgurk)
                {
                    Game.Player.ChangeModel("cs_gurk");
                    Screen.ShowSubtitle("Ped set to ~b~Gurk");
                }
            };
            
            var cshunter = new UIMenuItem("Hunter", "Changes your ped model to Hunter");
            cutscene.AddItem(cshunter);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == cshunter)
                {
                    Game.Player.ChangeModel("cs_hunter");
                    Screen.ShowSubtitle("Ped set to ~b~Hunter");
                }
            };
            
            var csjanet = new UIMenuItem("Janet", "Changes your ped model to Janet");
            cutscene.AddItem(csjanet);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csjanet)
                {
                    Game.Player.ChangeModel("cs_janet");
                    Screen.ShowSubtitle("Ped set to ~b~Janet");
                }
            };
            
            var csjewelass = new UIMenuItem("Jewel Assistant", "Changes your ped model to Jewel Assistant");
            cutscene.AddItem(csjewelass);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csjewelass)
                {
                    Game.Player.ChangeModel("cs_jewelass");
                    Screen.ShowSubtitle("Ped set to ~b~Jewel Assistant");
                }
            };
            
            var csjimmyboston = new UIMenuItem("Jimmy Boston", "Changes your ped model to Jimmy Boston");
            cutscene.AddItem(csjimmyboston);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csjimmyboston)
                {
                    Game.Player.ChangeModel("cs_jimmyboston");
                    Screen.ShowSubtitle("Ped set to ~b~Jimmy Boston");
                }
            };
            
            var csjimmydisant = new UIMenuItem("Jimmy De Santa", "Changes your ped model to Jimmy De Santa");
            cutscene.AddItem(csjimmydisant);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csjimmydisant)
                {
                    Game.Player.ChangeModel("cs_jimmydisanto");
                    Screen.ShowSubtitle("Ped set to ~b~Jimmy De Santa");
                }
            };
            
            var csjoeminuteman = new UIMenuItem("Joe Minuteman", "Changes your ped model to Joe Minuteman");
            cutscene.AddItem(csjoeminuteman);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csjoeminuteman)
                {
                    Game.Player.ChangeModel("cs_joeminuteman");
                    Screen.ShowSubtitle("Ped set to ~b~Joe Minuteman");
                }
            };
            
            var csjohnnyklebitz = new UIMenuItem("Johnny Klebitz", "Changes your ped model to Johnny Klebitz");
            cutscene.AddItem(csjohnnyklebitz);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csjohnnyklebitz)
                {
                    Game.Player.ChangeModel("cs_johnnyklebitz");
                    Screen.ShowSubtitle("Ped set to ~b~Johnny Klebitz");
                }
            };
            
            var csjosef = new UIMenuItem("Josef", "Changes your ped model to Josef");
            cutscene.AddItem(csjosef);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csjosef)
                {
                    Game.Player.ChangeModel("cs_josef");
                    Screen.ShowSubtitle("Ped set to ~b~Josef");
                }
            };
            
            var csjosh = new UIMenuItem("Josh", "Changes your ped model to Josh");
            cutscene.AddItem(csjosh);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csjosh)
                {
                    Game.Player.ChangeModel("cs_josh");
                    Screen.ShowSubtitle("Ped set to ~b~Josh");
                }
            };
            
            var cskarendaniels = new UIMenuItem("Karen Daniels", "Changes your ped model to Karen Daniels");
            cutscene.AddItem(cskarendaniels);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == cskarendaniels)
                {
                    Game.Player.ChangeModel("cs_karen_daniels");
                    Screen.ShowSubtitle("Ped set to ~b~Karen Daniels");
                }
            };
            
            var cslamardavis = new UIMenuItem("Lamar Davis", "Changes your ped model to Lamar Davis");
            cutscene.AddItem(cslamardavis);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == cslamardavis)
                {
                    Game.Player.ChangeModel("cs_lamardavis");
                    Screen.ShowSubtitle("Ped set to ~b~Lamar Davis");
                }
            };
            
            var cslazlow = new UIMenuItem("Lazlow", "Changes your ped model to Lazlow");
            cutscene.AddItem(cslazlow);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == cslazlow)
                {
                    Game.Player.ChangeModel("cs_lazlow");
                    Screen.ShowSubtitle("Ped set to ~b~Lazlow");
                }
            };
            
            var cslazlow2 = new UIMenuItem("Lazlow 2", "Changes your ped model to Lazlow 2");
            cutscene.AddItem(cslazlow2);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == cslazlow2)
                {
                    Game.Player.ChangeModel("cs_lazlow_2");
                    Screen.ShowSubtitle("Ped set to ~b~Lazlow 2");
                }
            };
            
            var cslestercrest = new UIMenuItem("Lester Crest", "Changes your ped model to Lester Crest");
            cutscene.AddItem(cslestercrest);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == cslestercrest)
                {
                    Game.Player.ChangeModel("cs_lestercrest");
                    Screen.ShowSubtitle("Ped set to ~b~Lester Crest");
                }
            };
            
            var cslifeinvad = new UIMenuItem("Lifeinvader", "Changes your ped model to Lifeinvader");
            cutscene.AddItem(cslifeinvad);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == cslifeinvad)
                {
                    Game.Player.ChangeModel("cs_lifeinvad_01");
                    Screen.ShowSubtitle("Ped set to ~b~Lifeinvader");
                }
            };
            
            var csmagenta = new UIMenuItem("Magenta", "Changes your ped model to Magenta");
            cutscene.AddItem(csmagenta);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csmagenta)
                {
                    Game.Player.ChangeModel("cs_magenta");
                    Screen.ShowSubtitle("Ped set to ~b~Magenta");
                }
            };
            
            var csmanuel = new UIMenuItem("Manuel", "Changes your ped model to Manuel");
            cutscene.AddItem(csmanuel);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csmanuel)
                {
                    Game.Player.ChangeModel("cs_manuel");
                    Screen.ShowSubtitle("Ped set to ~b~Manuel");
                }
            };
            
            var csmarnie = new UIMenuItem("Marnie", "Changes your ped model to Marnie");
            cutscene.AddItem(csmarnie);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csmarnie)
                {
                    Game.Player.ChangeModel("cs_marnie");
                    Screen.ShowSubtitle("Ped set to ~b~Marnie");
                }
            };
            
            var csmartinmadrazo = new UIMenuItem("Martin Madrazo", "Changes your ped model to Martin Madrazo");
            cutscene.AddItem(csmartinmadrazo);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csmartinmadrazo)
                {
                    Game.Player.ChangeModel("cs_martinmadrazo");
                    Screen.ShowSubtitle("Ped set to ~b~Martin Madrazo");
                }
            };
            
            var csmaryann = new UIMenuItem("Mary-Ann", "Changes your ped model to Mary-Ann");
            cutscene.AddItem(csmaryann);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csmaryann)
                {
                    Game.Player.ChangeModel("cs_maryann");
                    Screen.ShowSubtitle("Ped set to ~b~Mary-Ann");
                }
            };
            
            var csmichelle = new UIMenuItem("Michelle", "Changes your ped model to Michelle");
            cutscene.AddItem(csmichelle);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csmichelle)
                {
                    Game.Player.ChangeModel("cs_michelle");
                    Screen.ShowSubtitle("Ped set to ~b~Michelle");
                }
            };
            
            var csmilton = new UIMenuItem("Milton", "Changes your ped model to Milton");
            cutscene.AddItem(csmilton);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csmilton)
                {
                    Game.Player.ChangeModel("cs_milton");
                    Screen.ShowSubtitle("Ped set to ~b~Milton");
                }
            };
            
            var csmolly = new UIMenuItem("Molly", "Changes your ped model to Molly");
            cutscene.AddItem(csmolly);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csmolly)
                {
                    Game.Player.ChangeModel("cs_molly");
                    Screen.ShowSubtitle("Ped set to ~b~Molly");
                }
            };
            
            var csmovpremmale = new UIMenuItem("Movie Premiere (Male)", "Changes your ped model to Movie Premiere (Male)");
            cutscene.AddItem(csmovpremmale);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csmovpremmale)
                {
                    Game.Player.ChangeModel("cs_movpremmale");
                    Screen.ShowSubtitle("Ped set to ~b~Movie Premiere (Male)");
                }
            };
            
            var csmovpremf = new UIMenuItem("Movie Premiere (Female)", "Changes your ped model to Movie Premiere (Female)");
            cutscene.AddItem(csmovpremf);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csmovpremf)
                {
                    Game.Player.ChangeModel("cs_movpremf_01");
                    Screen.ShowSubtitle("Ped set to ~b~Movie Premiere (Female)");
                }
            };
            
            var csmrk = new UIMenuItem("MRK", "Changes your ped model to MRK");
            cutscene.AddItem(csmrk);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csmrk)
                {
                    Game.Player.ChangeModel("cs_mrk");
                    Screen.ShowSubtitle("Ped set to ~b~MRK");
                }
            };
            
            var csmrsthornhill = new UIMenuItem("Mrs. Thornhill", "Changes your ped model to Mrs. Thornhill");
            cutscene.AddItem(csmrsthornhill);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csmrsthornhill)
                {
                    Game.Player.ChangeModel("cs_mrs_thornhill");
                    Screen.ShowSubtitle("Ped set to ~b~Mrs. Thornhill");
                }
            };
            
            var csmrsphillips = new UIMenuItem("Mrs. Phillips", "Changes your ped model to Mrs. Phillips");
            cutscene.AddItem(csmrsphillips);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csmrsphillips)
                {
                    Game.Player.ChangeModel("cs_mrsphillips");
                    Screen.ShowSubtitle("Ped set to ~b~Mrs. Phillips");
                }
            };
            
            var csnatalia = new UIMenuItem("Natalia", "Changes your ped model to Natalia");
            cutscene.AddItem(csnatalia);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csnatalia)
                {
                    Game.Player.ChangeModel("cs_natalia");
                    Screen.ShowSubtitle("Ped set to ~b~Natalia");
                }
            };
            
            var csnervousron = new UIMenuItem("Nervous Ron", "Changes your ped model to Nervous Ron");
            cutscene.AddItem(csnervousron);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csnervousron)
                {
                    Game.Player.ChangeModel("cs_nervousron");
                    Screen.ShowSubtitle("Ped set to ~b~Nervous Ron");
                }
            };
            
            var csnigel = new UIMenuItem("Nigel", "Changes your ped model to Nigel");
            cutscene.AddItem(csnigel);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csnigel)
                {
                    Game.Player.ChangeModel("cs_nigel");
                    Screen.ShowSubtitle("Ped set to ~b~Nigel");
                }
            };
            
            var csoldman = new UIMenuItem("Old Man 1", "Changes your ped model to an Old Man");
            cutscene.AddItem(csoldman);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csoldman)
                {
                    Game.Player.ChangeModel("cs_old_man1a");
                    Screen.ShowSubtitle("Ped set to ~b~Old Man");
                }
            };
            
            var csoldman2 = new UIMenuItem("Old Man 2", "Changes your ped model to an Old Man");
            cutscene.AddItem(csoldman2);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csoldman2)
                {
                    Game.Player.ChangeModel("cs_old_man2");
                    Screen.ShowSubtitle("Ped set to ~b~Old Man");
                }
            };
            
            var csomega = new UIMenuItem("Omega", "Changes your ped model to Omega");
            cutscene.AddItem(csomega);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csomega)
                {
                    Game.Player.ChangeModel("cs_omega");
                    Screen.ShowSubtitle("Ped set to ~b~Omega");
                }
            };
            
            var csorleans = new UIMenuItem("Orleans", "Changes your ped model to Orleans");
            cutscene.AddItem(csorleans);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csorleans)
                {
                    Game.Player.ChangeModel("cs_orleans");
                    Screen.ShowSubtitle("Ped set to ~b~Orleans");
                }
            };
            
            var cspaper = new UIMenuItem("Paper", "Changes your ped model to Paper");
            cutscene.AddItem(cspaper);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == cspaper)
                {
                    Game.Player.ChangeModel("cs_paper");
                    Screen.ShowSubtitle("Ped set to ~b~Paper");
                }
            };
            
            var cspatricia = new UIMenuItem("Patricia", "Changes your ped model to Patricia");
            cutscene.AddItem(cspatricia);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == cspatricia)
                {
                    Game.Player.ChangeModel("cs_patricia");
                    Screen.ShowSubtitle("Ped set to ~b~Patricia");
                }
            };
            
            var cspriest = new UIMenuItem("Priest", "Changes your ped model to a Priest");
            cutscene.AddItem(cspriest);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == cspriest)
                {
                    Game.Player.ChangeModel("cs_priest");
                    Screen.ShowSubtitle("Ped set to ~b~Priest");
                }
            };
            
            var csrussiandrunk = new UIMenuItem("Russian Drunk", "Changes your ped model to a Russian Drunk");
            cutscene.AddItem(csrussiandrunk);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csrussiandrunk)
                {
                    Game.Player.ChangeModel("cs_russiandrunk");
                    Screen.ShowSubtitle("Ped set to ~b~Russian Drunk");
                }
            };
            
            var cssiemonyetarian = new UIMenuItem("Simeon Yetarian", "Changes your ped model to Simeon Yetarian");
            cutscene.AddItem(cssiemonyetarian);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == cssiemonyetarian)
                {
                    Game.Player.ChangeModel("cs_siemonyetarian");
                    Screen.ShowSubtitle("Ped set to ~b~Simeon Yetarian");
                }
            };
            
            var cssolomon = new UIMenuItem("Solomon", "Changes your ped model to Solomon");
            cutscene.AddItem(cssolomon);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == cssolomon)
                {
                    Game.Player.ChangeModel("cs_solomon");
                    Screen.ShowSubtitle("Ped set to ~b~Solomon");
                }
            };
            
            var csstevehains = new UIMenuItem("Steve Hains", "Changes your ped model to Steve Hains");
            cutscene.AddItem(csstevehains);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csstevehains)
                {
                    Game.Player.ChangeModel("cs_stevehains");
                    Screen.ShowSubtitle("Ped set to ~b~Steve Hains");
                }
            };
            
            var csstretch = new UIMenuItem("Stretch", "Changes your ped model to Stretch");
            cutscene.AddItem(csstretch);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csstretch)
                {
                    Game.Player.ChangeModel("cs_stretch");
                    Screen.ShowSubtitle("Ped set to ~b~Stretch");
                }
            };
            
            var cstanisha = new UIMenuItem("Tanisha", "Changes your ped model to Tanisha");
            cutscene.AddItem(cstanisha);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == cstanisha)
                {
                    Game.Player.ChangeModel("cs_tanisha");
                    Screen.ShowSubtitle("Ped set to ~b~Tanisha");
                }
            };
            
            var cstaocheng = new UIMenuItem("Tao Cheng", "Changes your ped model to Tao Cheng");
            cutscene.AddItem(cstaocheng);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == cstaocheng)
                {
                    Game.Player.ChangeModel("cs_taocheng");
                    Screen.ShowSubtitle("Ped set to ~b~Tao Cheng");
                }
            };
            
            var cstaostranslator = new UIMenuItem("Taos Translator", "Changes your ped model to Taos Translator");
            cutscene.AddItem(cstaostranslator);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == cstaostranslator)
                {
                    Game.Player.ChangeModel("cs_taostranslator");
                    Screen.ShowSubtitle("Ped set to ~b~Taos Translator");
                }
            };
            
            var cstenniscoach = new UIMenuItem("Tennis Coach", "Changes your ped model to Tennis Coach");
            cutscene.AddItem(cstenniscoach);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == cstenniscoach)
                {
                    Game.Player.ChangeModel("cs_tenniscoach");
                    Screen.ShowSubtitle("Ped set to ~b~Tennis Coach");
                }
            };
            
            var csterry = new UIMenuItem("Terry", "Changes your ped model to Terry");
            cutscene.AddItem(csterry);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csterry)
                {
                    Game.Player.ChangeModel("cs_terry");
                    Screen.ShowSubtitle("Ped set to ~b~Terry");
                }
            };
            
            var cstom = new UIMenuItem("Tom", "Changes your ped model to Tom");
            cutscene.AddItem(cstom);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == cstom)
                {
                    Game.Player.ChangeModel("cs_tom");
                    Screen.ShowSubtitle("Ped set to ~b~Tom");
                }
            };
            
            var cstomepsilon = new UIMenuItem("Tom Epsilon", "Changes your ped model to Tom Epsilon");
            cutscene.AddItem(cstomepsilon);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == cstomepsilon)
                {
                    Game.Player.ChangeModel("cs_tomepsilon");
                    Screen.ShowSubtitle("Ped set to ~b~Tom Epsilon");
                }
            };
            
            var cstracydisanto = new UIMenuItem("Tracy De Santa", "Changes your ped model to Tracy De Santa");
            cutscene.AddItem(cstracydisanto);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == cstracydisanto)
                {
                    Game.Player.ChangeModel("cs_tracydisanto");
                    Screen.ShowSubtitle("Ped set to ~b~Tracy De Santa");
                }
            };
            
            var cswade = new UIMenuItem("Wade", "Changes your ped model to Wade");
            cutscene.AddItem(cswade);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == cswade)
                {
                    Game.Player.ChangeModel("cs_wade");
                    Screen.ShowSubtitle("Ped set to ~b~Wade");
                }
            };
            
            var cszimbor = new UIMenuItem("Zimbor", "Changes your ped model to Zimbor");
            cutscene.AddItem(cszimbor);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == cszimbor)
                {
                    Game.Player.ChangeModel("cs_zimbor");
                    Screen.ShowSubtitle("Ped set to ~b~Zimbor");
                }
            };
            
            var csbabigail = new UIMenuItem("Abigail", "Changes your ped model to Abigail");
            cutscene.AddItem(csbabigail);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbabigail)
                {
                    Game.Player.ChangeModel("csb_abigail");
                    Screen.ShowSubtitle("Ped set to ~b~Abigail");
                }
            };
            
            var csbagent = new UIMenuItem("Agent", "Changes your ped model to Agent");
            cutscene.AddItem(csbagent);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbagent)
                {
                    Game.Player.ChangeModel("csb_agent");
                    Screen.ShowSubtitle("Ped set to ~b~Agent");
                }
            };
            
            var csbalan = new UIMenuItem("Alan", "Changes your ped model to Alan");
            cutscene.AddItem(csbalan);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbalan)
                {
                    Game.Player.ChangeModel("csb_alan");
                    Screen.ShowSubtitle("Ped set to ~b~Alan");
                }
            };
            
            var csbanita = new UIMenuItem("Anita", "Changes your ped model to Anita");
            cutscene.AddItem(csbanita);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbanita)
                {
                    Game.Player.ChangeModel("csb_anita");
                    Screen.ShowSubtitle("Ped set to ~b~Anita");
                }
            };
            
            var csbanton = new UIMenuItem("Anton", "Changes your ped model to Anton");
            cutscene.AddItem(csbanton);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbanton)
                {
                    Game.Player.ChangeModel("csb_anton");
                    Screen.ShowSubtitle("Ped set to ~b~Anton");
                }
            };
            
            var csbballasog = new UIMenuItem("Ballas OG", "Changes your ped model to Ballas OG");
            cutscene.AddItem(csbballasog);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbballasog)
                {
                    Game.Player.ChangeModel("csb_ballasog");
                    Screen.ShowSubtitle("Ped set to ~b~Ballas OG");
                }
            };
            
            var csbbogdan = new UIMenuItem("Bogdan", "Changes your ped model to Bogdan");
            cutscene.AddItem(csbbogdan);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbbogdan)
                {
                    Game.Player.ChangeModel("csb_bogdan");
                    Screen.ShowSubtitle("Ped set to ~b~Bogdan");
                }
            };
            
            var csbbride = new UIMenuItem("Bride", "Changes your ped model to Bride");
            cutscene.AddItem(csbbride);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbbride)
                {
                    Game.Player.ChangeModel("csb_bride");
                    Screen.ShowSubtitle("Ped set to ~b~Bride");
                }
            };
            
            var csbbryony = new UIMenuItem("Bryony", "Changes your ped model to Bryony");
            cutscene.AddItem(csbbryony);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbbryony)
                {
                    Game.Player.ChangeModel("csb_bryony");
                    Screen.ShowSubtitle("Ped set to ~b~Bryony");
                }
            };
            
            var csbburgerdrug = new UIMenuItem("Burger Drug", "Changes your ped model to Burger Drug");
            cutscene.AddItem(csbburgerdrug);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbburgerdrug)
                {
                    Game.Player.ChangeModel("csb_burgerdrug");
                    Screen.ShowSubtitle("Ped set to ~b~Burger Drug");
                }
            };
            
            var csbcar3guy1 = new UIMenuItem("Car Guy 1", "Changes your ped model to Car Guy");
            cutscene.AddItem(csbcar3guy1);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbcar3guy1)
                {
                    Game.Player.ChangeModel("csb_car3guy1");
                    Screen.ShowSubtitle("Ped set to ~b~Car Guy");
                }
            };
            
            var csbcar3guy2 = new UIMenuItem("Car Guy 2", "Changes your ped model to Car Guy");
            cutscene.AddItem(csbcar3guy2);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbcar3guy2)
                {
                    Game.Player.ChangeModel("csb_car3guy2");
                    Screen.ShowSubtitle("Ped set to ~b~Car Guy");
                }
            };
            
            var csbchef = new UIMenuItem("Chef 1", "Changes your ped model to Chef");
            cutscene.AddItem(csbchef);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbchef)
                {
                    Game.Player.ChangeModel("csb_chef");
                    Screen.ShowSubtitle("Ped set to ~b~Chef");
                }
            };
            
            var csbchef2 = new UIMenuItem("Chef 2", "Changes your ped model to Chef");
            cutscene.AddItem(csbchef2);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbchef2)
                {
                    Game.Player.ChangeModel("csb_chef2");
                    Screen.ShowSubtitle("Ped set to ~b~Chef");
                }
            };
            
            var csbchingoon = new UIMenuItem("China Goon", "Changes your ped model to China Goon");
            cutscene.AddItem(csbchingoon);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbchingoon)
                {
                    Game.Player.ChangeModel("csb_chin_goon");
                    Screen.ShowSubtitle("Ped set to ~b~China Goon");
                }
            };
            
            var csbcletus = new UIMenuItem("Cletus", "Changes your ped model to Cletus");
            cutscene.AddItem(csbcletus);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbcletus)
                {
                    Game.Player.ChangeModel("csb_cletus");
                    Screen.ShowSubtitle("Ped set to ~b~Cletus");
                }
            };
            
            var csbcustomer = new UIMenuItem("Customer", "Changes your ped model to Customer");
            cutscene.AddItem(csbcustomer);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbcustomer)
                {
                    Game.Player.ChangeModel("csb_customer");
                    Screen.ShowSubtitle("Ped set to ~b~Customer");
                }
            };
            
            var csbdenisefriend = new UIMenuItem("Denise Friend", "Changes your ped model to Denise Friend");
            cutscene.AddItem(csbdenisefriend);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbdenisefriend)
                {
                    Game.Player.ChangeModel("csb_denise_friend");
                    Screen.ShowSubtitle("Ped set to ~b~Denise Friend");
                }
            };
            
            var csbdix = new UIMenuItem("Dix", "Changes your ped model to Dix");
            cutscene.AddItem(csbdix);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbdix)
                {
                    Game.Player.ChangeModel("csb_dix");
                    Screen.ShowSubtitle("Ped set to ~b~Dix");
                }
            };
            
            var csbdjblamadon = new UIMenuItem("DJ Blamadon", "Changes your ped model to DJ Blamadon");
            cutscene.AddItem(csbdjblamadon);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbdjblamadon)
                {
                    Game.Player.ChangeModel("csb_djblamadon");
                    Screen.ShowSubtitle("Ped set to ~b~DJ Blamadon");
                }
            };
            
            var csbenglishdave = new UIMenuItem("English Dave", "Changes your ped model to English Dave");
            cutscene.AddItem(csbenglishdave);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbenglishdave)
                {
                    Game.Player.ChangeModel("csb_englishdave");
                    Screen.ShowSubtitle("Ped set to ~b~English Dave");
                }
            };
            
            var csbfosrep = new UIMenuItem("Fos Rep", "Changes your ped model to Fos Rep");
            cutscene.AddItem(csbfosrep);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbfosrep)
                {
                    Game.Player.ChangeModel("csb_fos_rep");
                    Screen.ShowSubtitle("Ped set to ~b~Fos Rep");
                }
            };
            
            var csbg = new UIMenuItem("G", "Changes your ped model to G");
            cutscene.AddItem(csbg);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbg)
                {
                    Game.Player.ChangeModel("csb_g");
                    Screen.ShowSubtitle("Ped set to ~b~G");
                }
            };
            
            var csbgroom = new UIMenuItem("G", "Changes your ped model to a Groom");
            cutscene.AddItem(csbgroom);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbgroom)
                {
                    Game.Player.ChangeModel("csb_groom");
                    Screen.ShowSubtitle("Ped set to ~b~Groom");
                }
            };
            
            var csbgrovestrdlr = new UIMenuItem("Grove Street Dealer", "Changes your ped model to a Grove Street Dealer");
            cutscene.AddItem(csbgrovestrdlr);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbgrovestrdlr)
                {
                    Game.Player.ChangeModel("csb_grove_str_dlr");
                    Screen.ShowSubtitle("Ped set to ~b~Grove Street Dealer");
                }
            };
            
            var csbhao = new UIMenuItem("Hao", "Changes your ped model to Hao");
            cutscene.AddItem(csbhao);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbhao)
                {
                    Game.Player.ChangeModel("csb_hao");
                    Screen.ShowSubtitle("Ped set to ~b~Hao");
                }
            };
            
            var csbhugh = new UIMenuItem("Hugh", "Changes your ped model to Hugh");
            cutscene.AddItem(csbhugh);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbhugh)
                {
                    Game.Player.ChangeModel("csb_hugh");
                    Screen.ShowSubtitle("Ped set to ~b~Hugh");
                }
            };
            
            var csbimran = new UIMenuItem("Imran", "Changes your ped model to Imran");
            cutscene.AddItem(csbimran);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbimran)
                {
                    Game.Player.ChangeModel("csb_imran");
                    Screen.ShowSubtitle("Ped set to ~b~Imran");
                }
            };
            
            var csbjackhowitzer = new UIMenuItem("Jack Howitzer", "Changes your ped model to Jack Howitzer");
            cutscene.AddItem(csbjackhowitzer);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbjackhowitzer)
                {
                    Game.Player.ChangeModel("csb_jackhowitzer");
                    Screen.ShowSubtitle("Ped set to ~b~Jack Howitzer");
                }
            };
            
            var csbjanitor = new UIMenuItem("Janitor", "Changes your ped model to a Janitor");
            cutscene.AddItem(csbjanitor);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbjanitor)
                {
                    Game.Player.ChangeModel("csb_janitor");
                    Screen.ShowSubtitle("Ped set to ~b~Janitor");
                }
            };
            
            var csbmaude = new UIMenuItem("Maude", "Changes your ped model to Maude");
            cutscene.AddItem(csbmaude);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbmaude)
                {
                    Game.Player.ChangeModel("csb_maude");
                    Screen.ShowSubtitle("Ped set to ~b~Maude");
                }
            };
            
            var csbmoney = new UIMenuItem("Money", "Changes your ped model to Money");
            cutscene.AddItem(csbmoney);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbmoney)
                {
                    Game.Player.ChangeModel("csb_money");
                    Screen.ShowSubtitle("Ped set to ~b~Money");
                }
            };
            
            var csbmpagent14 = new UIMenuItem("Agent 14", "Changes your ped model to Agent 14");
            cutscene.AddItem(csbmpagent14);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbmpagent14)
                {
                    Game.Player.ChangeModel("csb_mp_agent14");
                    Screen.ShowSubtitle("Ped set to ~b~Agent 14");
                }
            };
            
            var csbmrsr = new UIMenuItem("Mrs. R", "Changes your ped model to Mrs. R");
            cutscene.AddItem(csbmrsr);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbmrsr)
                {
                    Game.Player.ChangeModel("csb_mrs_r");
                    Screen.ShowSubtitle("Ped set to ~b~Mrs. R");
                }
            };
            
            var csbmweather = new UIMenuItem("Merryweather", "Changes your ped model to Merryweather");
            cutscene.AddItem(csbmweather);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbmweather)
                {
                    Game.Player.ChangeModel("csb_mweather");
                    Screen.ShowSubtitle("Ped set to ~b~Merryweather");
                }
            };
            
            var csbortega = new UIMenuItem("Ortega", "Changes your ped model to Ortega");
            cutscene.AddItem(csbortega);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbortega)
                {
                    Game.Player.ChangeModel("csb_ortega");
                    Screen.ShowSubtitle("Ped set to ~b~Ortega");
                }
            };
            
            var csboscar = new UIMenuItem("Oscar", "Changes your ped model to Oscar");
            cutscene.AddItem(csboscar);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csboscar)
                {
                    Game.Player.ChangeModel("csb_oscar");
                    Screen.ShowSubtitle("Ped set to ~b~Oscar");
                }
            };
            
            var csbpaige = new UIMenuItem("Paige", "Changes your ped model to Paige");
            cutscene.AddItem(csbpaige);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbpaige)
                {
                    Game.Player.ChangeModel("csb_paige");
                    Screen.ShowSubtitle("Ped set to ~b~Paige");
                }
            };
            
            var csbpopov = new UIMenuItem("Popov", "Changes your ped model to Popov");
            cutscene.AddItem(csbpopov);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbpopov)
                {
                    Game.Player.ChangeModel("csb_popov");
                    Screen.ShowSubtitle("Ped set to ~b~Popov");
                }
            };
            
            var csbporndudes = new UIMenuItem("Porn Dude", "Changes your ped model to a Porn Dude");
            cutscene.AddItem(csbporndudes);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbporndudes)
                {
                    Game.Player.ChangeModel("csb_porndudes");
                    Screen.ShowSubtitle("Ped set to ~b~Porn Dude");
                }
            };
            
            var csbprologuedriver = new UIMenuItem("Prologue Driver", "Changes your ped model to Prologue Driver");
            cutscene.AddItem(csbprologuedriver);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbprologuedriver)
                {
                    Game.Player.ChangeModel("csb_prologuedriver");
                    Screen.ShowSubtitle("Ped set to ~b~Prologue Driver");
                }
            };
            
            var csbrampgang = new UIMenuItem("Gang Member", "Changes your ped model to a Gang Member");
            cutscene.AddItem(csbrampgang);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbrampgang)
                {
                    Game.Player.ChangeModel("csb_ramp_gang");
                    Screen.ShowSubtitle("Ped set to ~b~Gang Member");
                }
            };
            
            var csbramphic = new UIMenuItem("Hick", "Changes your ped model to a Hick");
            cutscene.AddItem(csbramphic);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbramphic)
                {
                    Game.Player.ChangeModel("csb_ramp_hic");
                    Screen.ShowSubtitle("Ped set to ~b~Hick");
                }
            };
            
            var csbramphipster = new UIMenuItem("Hipster", "Changes your ped model to a Hipster");
            cutscene.AddItem(csbramphipster);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbramphipster)
                {
                    Game.Player.ChangeModel("csb_ramp_hipster");
                    Screen.ShowSubtitle("Ped set to ~b~Hipster");
                }
            };
            
            var csbrampmarine = new UIMenuItem("Marine", "Changes your ped model to a Marine");
            cutscene.AddItem(csbrampmarine);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbrampmarine)
                {
                    Game.Player.ChangeModel("csb_ramp_marine");
                    Screen.ShowSubtitle("Ped set to ~b~Marine");
                }
            };
            
            var csbrampmex = new UIMenuItem("Mexican", "Changes your ped model to a Mexican");
            cutscene.AddItem(csbrampmex);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbrampmex)
                {
                    Game.Player.ChangeModel("csb_ramp_mex");
                    Screen.ShowSubtitle("Ped set to ~b~Mexican");
                }
            };
            
            var csbrashcosvki = new UIMenuItem("Rashcosvki", "Changes your ped model to Rashcosvki");
            cutscene.AddItem(csbrashcosvki);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbrashcosvki)
                {
                    Game.Player.ChangeModel("csb_rashcosvki");
                    Screen.ShowSubtitle("Ped set to ~b~Rashcosvki");
                }
            };
            
            var csbreporter = new UIMenuItem("Reporter", "Changes your ped model to a Reporter");
            cutscene.AddItem(csbreporter);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbreporter)
                {
                    Game.Player.ChangeModel("csb_reporter");
                    Screen.ShowSubtitle("Ped set to ~b~Reporter");
                }
            };
            
            var csbroccopelosi = new UIMenuItem("Rocco Pelosi", "Changes your ped model to Rocco Pelosi");
            cutscene.AddItem(csbroccopelosi);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbroccopelosi)
                {
                    Game.Player.ChangeModel("csb_roccopelosi");
                    Screen.ShowSubtitle("Ped set to ~b~Rocco Pelosi");
                }
            };
            
            var csbscreenwriter = new UIMenuItem("Screen Writer", "Changes your ped model to a Screen Writer");
            cutscene.AddItem(csbscreenwriter);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbscreenwriter)
                {
                    Game.Player.ChangeModel("csb_screen_writer");
                    Screen.ShowSubtitle("Ped set to ~b~Screen Writer");
                }
            };
            
            var csbsol = new UIMenuItem("Sol", "Changes your ped model to Sol");
            cutscene.AddItem(csbsol);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbsol)
                {
                    Game.Player.ChangeModel("csb_sol");
                    Screen.ShowSubtitle("Ped set to ~b~Sol");
                }
            };
            
            var csbstripper1 = new UIMenuItem("Stripper 1 ~r~EXPLICIT", "Changes your ped model to a Stripper");
            cutscene.AddItem(csbstripper1);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbstripper1)
                {
                    Game.Player.ChangeModel("csb_stripper_01");
                    Screen.ShowSubtitle("Ped set to ~b~Stripper");
                }
            };
            
            var csbstripper2 = new UIMenuItem("Stripper 2 ~r~EXPLICIT", "Changes your ped model to a Stripper");
            cutscene.AddItem(csbstripper1);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbstripper1)
                {
                    Game.Player.ChangeModel("csb_stripper_02");
                    Screen.ShowSubtitle("Ped set to ~b~Stripper");
                }
            };

            var csbtalcc = new UIMenuItem("Talcc", "Changes your ped model to Talcc");
            cutscene.AddItem(csbtalcc);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbtalcc)
                {
                    Game.Player.ChangeModel("csb_talcc");
                    Screen.ShowSubtitle("Ped set to ~b~Talcc");
                }
            };
            
            var csbtalmm = new UIMenuItem("Talmm", "Changes your ped model to Talmm");
            cutscene.AddItem(csbtalmm);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbtalmm)
                {
                    Game.Player.ChangeModel("csb_talmm");
                    Screen.ShowSubtitle("Ped set to ~b~Talmm");
                }
            };
            
            var csbtonya = new UIMenuItem("Tonya", "Changes your ped model to Tonya");
            cutscene.AddItem(csbtonya);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbtonya)
                {
                    Game.Player.ChangeModel("csb_tonya");
                    Screen.ShowSubtitle("Ped set to ~b~Tonya");
                }
            };
            
            var csbtonyprince = new UIMenuItem("Tony Prince", "Changes your ped model to Tony Prince");
            cutscene.AddItem(csbtonyprince);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbtonyprince)
                {
                    Game.Player.ChangeModel("csb_tonyprince");
                    Screen.ShowSubtitle("Ped set to ~b~Tony Prince");
                }
            };
            
            var csbundercover = new UIMenuItem("Undercover", "Changes your ped model to Undercover");
            cutscene.AddItem(csbundercover);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbundercover)
                {
                    Game.Player.ChangeModel("csb_undercover");
                    Screen.ShowSubtitle("Ped set to ~b~Undercover");
                }
            };
            
            var csbvagspeak = new UIMenuItem("Vagspeak", "Changes your ped model to Vagspeak");
            cutscene.AddItem(csbvagspeak);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbvagspeak)
                {
                    Game.Player.ChangeModel("csb_vagspeak");
                    Screen.ShowSubtitle("Ped set to ~b~Vagsoeak");
                }
            };
            
            var csbagatha = new UIMenuItem("Agatha", "Changes your ped model to Agatha");
            cutscene.AddItem(csbagatha);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbagatha)
                {
                    Game.Player.ChangeModel("csb_agatha");
                    Screen.ShowSubtitle("Ped set to ~b~Agatha");
                }
            };
            
            var csbagatha = new UIMenuItem("Agatha", "Changes your ped model to Agatha");
            cutscene.AddItem(csbagatha);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbagatha)
                {
                    Game.Player.ChangeModel("csb_agatha");
                    Screen.ShowSubtitle("Ped set to ~b~Agatha");
                }
            };
            
            var csbavery = new UIMenuItem("Avery", "Changes your ped model to Avery");
            cutscene.AddItem(csbavery);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbavery)
                {
                    Game.Player.ChangeModel("csb_avery");
                    Screen.ShowSubtitle("Ped set to ~b~Avery");
                }
            };
            
            var csbbrucie2 = new UIMenuItem("Brucie", "Changes your ped model to Brucie");
            cutscene.AddItem(csbbrucie2);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbbrucie2)
                {
                    Game.Player.ChangeModel("csb_brucie2");
                    Screen.ShowSubtitle("Ped set to ~b~Brucie");
                }
            };
            
            var csbthornton = new UIMenuItem("Thornton", "Changes your ped model to Thornton");
            cutscene.AddItem(csbthornton);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbthornton)
                {
                    Game.Player.ChangeModel("csb_thornton");
                    Screen.ShowSubtitle("Ped set to ~b~Thornton");
                }
            };
            
            var csbtomcasino = new UIMenuItem("Tom Casino", "Changes your ped model to Tom Casino");
            cutscene.AddItem(csbtomcasino);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbtomcasino)
                {
                    Game.Player.ChangeModel("csb_tommcasino");
                    Screen.ShowSubtitle("Ped set to ~b~Tom Casino");
                }
            };
            
            var csbvincent = new UIMenuItem("Vincent", "Changes your ped model to Vincent");
            cutscene.AddItem(csbtomcasino);
            cutscene.OnItemSelect += (sender, item, index) =>
            {
                if (item == csbvincent)
                {
                    Game.Player.ChangeModel("csb_vincent");
                    Screen.ShowSubtitle("Ped set to ~b~Vincent");
                }
            };
        }
            
        public MainMenu()
        {
            _menuPool    = new MenuPool();
            var mainMenu = new UIMenu("Ped Menu", "~r~v0.3 ALPHA ~b~(Asteroid Scripts)");
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