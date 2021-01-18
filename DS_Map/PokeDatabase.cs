﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPRE {
    public abstract class PokeDatabase {
        public abstract class MusicDB {
            public static Dictionary<ushort, string> DPMusicValues = new Dictionary<ushort, string>() {
                [1000] = "Mystery Zone",
                [1001] = "Silence",
                [1002] = "Pal Park",
                [1004] = "Twinleaf Town (Day)",
                [1005] = "Sandgem Town (Day)",
                [1006] = "Floaroma Town (Day)",
                [1008] = "Route 225 (Day)",
                [1009] = "Valor Lakefront (Day)",
                [1010] = "Jubilife City (Day)",
                [1011] = "Canalave City (Day)",
                [1012] = "Oreburgh City (Day)",
                [1013] = "Eterna City (Day)",
                [1014] = "Hearthome City (Day)",
                [1015] = "Pastoria City (Day)",
                [1016] = "Veilstone City (Day)",
                [1017] = "Sunyshore City (Day)",
                [1018] = "Snowpoint City (Day)",
                [1019] = "Pokémon League (Day)",
                [1020] = "Fight Area (Day)",
                [1021] = "Route 201 (Day)",
                [1022] = "Route 203 (Day)",
                [1023] = "Route 205 (Day)",
                [1024] = "Route 206 (Day)",
                [1025] = "Route 209 (Day)",
                [1026] = "Route 215 (Day)",
                [1027] = "Route 216 (Day)",
                [1028] = "Route 228 (Day)",
                [1033] = "Twinleaf Town (Night)",
                [1034] = "Sandgem Town (Night)",
                [1035] = "Floaroma Town (Night)",
                [1037] = "Route 225 (Night)",
                [1038] = "Valor Lakefront (Night)",
                [1039] = "Jubilife City (Night)",
                [1040] = "Canalave City (Night)",
                [1041] = "Oreburgh City (Night)",
                [1042] = "Eterna City (Night)",
                [1043] = "Hearthome CIty (Night)",
                [1044] = "Pastoria City (Night)",
                [1045] = "Veilstone City (Night)",
                [1046] = "Sunyshore City (Night)",
                [1047] = "Snowpoint City (Night)",
                [1048] = "Pokémon League (Night)",
                [1049] = "Fight Area (Night)",
                [1050] = "Route 201 (Night)",
                [1051] = "Route 203 (Night)",
                [1052] = "Route 205 (Night)",
                [1053] = "Route 206 (Night)",
                [1054] = "Route 209 (Night)",
                [1055] = "Route 215 (Night)",
                [1056] = "Route 216 (Night)",
                [1057] = "Route 228 (Night)",
                [1060] = "Mystery Zone",
                [1062] = "Victory Road",
                [1063] = "Eterna Forest",
                [1064] = "Old Chateau",
                [1065] = "Cavern on the Lake",
                [1066] = "Amity Square",
                [1067] = "Team Galactic HQ",
                [1068] = "Eterna Galactic building",
                [1069] = "Great Marsh",
                [1070] = "Lake theme (Day)",
                [1071] = "Mt. Coronet",
                [1072] = "Spear Pillar",
                [1073] = "Stark Mountain (inside)",
                [1074] = "Cave 1",
                [1075] = "Cave 2",
                [1076] = "Elite 4 - Showdown",
                [1077] = "Hall of Fame",
                [1085] = "Pokémon Center (Day)",
                [1086] = "Pokémon Center (Night)",
                [1087] = "Gym theme",
                [1088] = "Rowan's Lab",
                [1089] = "Poffin House",
                [1090] = "Pokémon Mart",
                [1091] = "Game Corner",
                [1092] = "Battle Tower (inside)",
                [1093] = "Jubilife TV",
                [1094] = "Team Galactic Lab",
                [1096] = "Hall of Origin",
                [1097] = "GTS theme"
            };
            public static Dictionary<ushort, string> PtMusicValues = new Dictionary<ushort, string>() {
                [1000] = "Mystery Zone",
                [1001] = "Silence",
                [1002] = "Pal Park",
                [1004] = "Twinleaf Town (Day)",
                [1005] = "Sandgem Town (Day)",
                [1006] = "Floaroma Town (Day)",
                [1008] = "Route 225 (Day)",
                [1009] = "Valor Lakefront (Day)",
                [1010] = "Jubilife City (Day)",
                [1011] = "Canalave City (Day)",
                [1012] = "Oreburgh City (Day)",
                [1013] = "Eterna City (Day)",
                [1014] = "Hearthome City (Day)",
                [1015] = "Pastoria City (Day)",
                [1016] = "Veilstone City (Day)",
                [1017] = "Sunyshore City (Day)",
                [1018] = "Snowpoint City (Day)",
                [1019] = "Pokémon League (Day)",
                [1020] = "Fight Area (Day)",
                [1021] = "Route 201 (Day)",
                [1022] = "Route 203 (Day)",
                [1023] = "Route 205 (Day)",
                [1024] = "Route 206 (Day)",
                [1025] = "Route 209 (Day)",
                [1026] = "Route 215 (Day)",
                [1027] = "Route 216 (Day)",
                [1028] = "Route 228 (Day)",
                [1033] = "Twinleaf Town (Night)",
                [1034] = "Sandgem Town (Night)",
                [1035] = "Floaroma Town (Night)",
                [1037] = "Route 225 (Night)",
                [1038] = "Valor Lakefront (Night)",
                [1039] = "Jubilife City (Night)",
                [1040] = "Canalave City (Night)",
                [1041] = "Oreburgh City (Night)",
                [1042] = "Eterna City (Night)",
                [1043] = "Hearthome CIty (Night)",
                [1044] = "Pastoria City (Night)",
                [1045] = "Veilstone City (Night)",
                [1046] = "Sunyshore City (Night)",
                [1047] = "Snowpoint City (Night)",
                [1048] = "Pokémon League (Night)",
                [1049] = "Fight Area (Night)",
                [1050] = "Route 201 (Night)",
                [1051] = "Route 203 (Night)",
                [1052] = "Route 205 (Night)",
                [1053] = "Route 206 (Night)",
                [1054] = "Route 209 (Night)",
                [1055] = "Route 215 (Night)",
                [1056] = "Route 216 (Night)",
                [1057] = "Route 228 (Night)",
                [1060] = "Mystery Zone",
                [1062] = "Victory Road",
                [1063] = "Eterna Forest",
                [1064] = "Old Chateau",
                [1065] = "Cavern on the Lake",
                [1066] = "Amity Square",
                [1067] = "Team Galactic HQ",
                [1068] = "Galactic Eterna Building",
                [1069] = "Great Marsh",
                [1070] = "Lake theme (Day)",
                [1071] = "Mt. Coronet",
                [1072] = "Spear Pillar",
                [1073] = "Stark Mountain (in)",
                [1074] = "Cave 1",
                [1075] = "Cave 2",
                [1076] = "Elite 4 - Showdown",
                [1077] = "Hall of Fame",
                [1085] = "Pokémon Center (Day)",
                [1086] = "Pokémon Center (Night)",
                [1087] = "Gym theme",
                [1088] = "Rowan's Lab",
                [1089] = "Poffin House",
                [1090] = "Pokémon Mart",
                [1091] = "Game Corner",
                [1092] = "Battle Tower (inside)",
                [1093] = "Jubilife TV",
                [1094] = "Team Galactic Lab",
                [1096] = "Hall of Origin",
                [1097] = "GTS theme",
                [1190] = "Distortion World",
                [1191] = "Battle Arcade",
                [1192] = "Battle Hall",
                [1193] = "Battle Castle",
                [1194] = "Battle Factory",
                [1195] = "Battle Factory",
                [1196] = "Global Terminal"
            };
            public static Dictionary<ushort, string> HGSSMusicValues = new Dictionary<ushort, string>() {
                [1000] = "Mystery Zone",
                [1001] = "Silence [Outside]",
                [1002] = "Silence [Dungeon]",
                [1004] = "Opening Theme",
                [1008] = "Title Screen Theme",
                [1013] = "Bicycle Theme",
                [1018] = "New Bark Town",
                [1019] = "Cherrygrove City",
                [1020] = "Violet City",
                [1021] = "Azalea Town",
                [1022] = "Goldenrod City",
                [1023] = "Ecruteak City",
                [1024] = "Olivine City",
                [1025] = "Cianwood City",
                [1026] = "Mahogany Town",
                [1027] = "Blackthorn City",
                [1028] = "Route 29",
                [1029] = "Route 30/31",
                [1030] = "Route 32",
                [1031] = "Route 33",
                [1032] = "Route 34",
                [1033] = "Route 35/36/37",
                [1034] = "Route 40/41",
                [1035] = "Route 45/46",
                [1036] = "Route 38/39",
                [1037] = "Route 42/43/44",
                [1038] = "Vermillion City",
                [1039] = "Saffron City",
                [1040] = "Cerulean City",
                [1041] = "Lavender Town",
                [1042] = "Celadon City",
                [1043] = "Fuchsia City",
                [1044] = "Pewter City",
                [1045] = "Viridian City",
                [1046] = "Pallet Town",
                [1047] = "Cinnabar Island",
                [1050] = "Route 1",
                [1051] = "Route 2/22",
                [1052] = "Route 6",
                [1053] = "Route 4/5/9/10",
                [1054] = "Route 8/10",
                [1055] = "Route 7/16",
                [1056] = "Route 18/19/20",
                [1057] = "Route 3",
                [1058] = "Route 20/21",
                [1059] = "Route 11",
                [1060] = "Route 12/13/14/15",
                [1061] = "Route 24/25",
                [1062] = "Route 26/27",
                [1063] = "Pokémon Center",
                [1064] = "Pokémon Mart",
                [1065] = "Gym theme",
                [1066] = "Prof. Elm Lab",
                [1068] = "Kimono Girls Theater",
                [1069] = "Game Corner",
                [1070] = "Battle Frontier",
                [1071] = "Battle Tower",
                [1072] = "Sprout Tower",
                [1073] = "Ilex Forest",
                [1074] = "Ruins of Alph",
                [1075] = "National Park",
                [1076] = "Burned Tower",
                [1077] = "Bell Tower",
                [1078] = "Lighthouse",
                [1079] = "Team Rocket HQ",
                [1080] = "Ice Path",
                [1081] = "Dragon's Den",
                [1082] = "Diglett's Cave",
                [1083] = "Viridian Forest",
                [1084] = "Victory Road",
                [1085] = "Indigo Plateau",
                [1092] = "PokéAthlon Game",
                [1096] = "S.S. Aqua",
                [1097] = "Mt. Moon Plaza",
                [1099] = "Sleeping Radio Music",
                [1100] = "Pokemon March Radio",
                [1101] = "Unown Radio",
                [1102] = "Pokeflute Radio",
                [1103] = "Prof. Oak's Theme/Radio",
                [1134] = "Pokéathlon Dome (In)",
                [1141] = "Pokéathlon Dome (Out)",
                [1143] = "Battle Factory",
                [1144] = "Battle Hall",
                [1145] = "Battle Arcade",
                [1146] = "Battle Castle",
                [1151] = "Wi-Fi Union Room",
                [1153] = "WiFi Plaza Parade",
                [1154] = "GTS Terminal",
                [1155] = "Spin Trade Theme",
                [1157] = "Route 47/48",
                [1158] = "Safari Zone Gate",
                [1159] = "Pal Park",
                [1160] = "Ethan's Theme",
                [1161] = "Lyra's Theme",
                [1163] = "Kimono Girls Ritual",
                [1164] = "Kimono Girls Theme",
                [1165] = "Battle! Ho-Oh!",
                [1166] = "Battle! Lugia",
                [1166] = "Spiky-Eared Pichu",
                [1168] = "Sinjoh Ruins",
                [1169] = "Route 101 Radio",
                [1170] = "Route 201 Radio",
                [1171] = "Gym Theme [Radio]",
                [1172] = "Azalea Town [Radio]",
                [1172] = "Goldenrod City [Radio]",
                [1173] = "Battle! Kyogre/Groudon",
                [1175] = "PokéWalker Theme",
                [1176] = "Battle! Arceus (Event)",
                [1216] = "Route 17"
            };
        }
        public static class MatrixCellColors{
            /* Initialize dictionary of colors corresponding to border maps in the matrix editor */
            public static Dictionary<List<uint>, Tuple<Color, Color>> mapColorsDPPt = new Dictionary<List<uint>, Tuple<Color, Color>> {
                [new List<uint> { 173, 176, 177, 179 }] = Tuple.Create(Color.ForestGreen, Color.White),
                [new List<uint> { 174 }] = Tuple.Create(Color.SteelBlue, Color.White),
                [new List<uint> { 175 }] = Tuple.Create(Color.Sienna, Color.White),
                [new List<uint> { 178 }] = Tuple.Create(Color.PowderBlue, Color.Black),
                [new List<uint> { Matrix.EMPTY }] = Tuple.Create(Color.Black, Color.White)
            };
            public static Dictionary<List<uint>, Tuple<Color, Color>> mapColorsHGSS = new Dictionary<List<uint>, Tuple<Color, Color>> {
                [new List<uint> { 208 }] = Tuple.Create(Color.ForestGreen, Color.White),
                [new List<uint> { 209 }] = Tuple.Create(Color.SteelBlue, Color.White),
                [new List<uint> { 210 }] = Tuple.Create(Color.Sienna, Color.White),
                [new List<uint> { Matrix.EMPTY }] = Tuple.Create(Color.Black, Color.White)
            };
            public static Dictionary<List<uint>, Tuple<Color, Color>> mapColorsGeneric = new Dictionary<List<uint>, Tuple<Color, Color>> {
                [new List<uint> { 203 }] = Tuple.Create(Color.FromArgb(80, 200, 16), Color.White),
                [new List<uint> { 204, 209 }] = Tuple.Create(Color.SteelBlue, Color.White),
                [new List<uint> { 205, 206 }] = Tuple.Create(Color.DarkGreen, Color.White),
                [new List<uint> { 207, 208 }] = Tuple.Create(Color.ForestGreen, Color.White),
                [new List<uint> { 210 }] = Tuple.Create(Color.Sienna, Color.White),
                [new List<uint> { Matrix.EMPTY }] = Tuple.Create(Color.Black, Color.White)
            };
        }

        public static class WeatherPics {
            public static Dictionary<int, string> dpweatherImageDict = new Dictionary<int, string>() {
                [0] = "dpnormal",
                [1] = "dpcloudy",
                [2] = "dprain",
                [3] = "dpheavyrain",
                [4] = "dpthunderstorm",
                [5] = "dpsnowslow",
                [6] = "dpdiamondsnow",
                [7] = "dpblizzard",
                [8] = "dpsandfall",
                [9] = "dpsandstorm",
                [10] = "dphail",
                [11] = "dprocksascending",
                [12] = "dpfog",
                [13] = "dpfog",
                [14] = "dpdark",
                [15] = "dplightning",
                [16] = "dplightsandstorm"
            };
            public static Dictionary<int, string> ptweatherImageDict = new Dictionary<int, string>() {
                [0] = "ptnormal",
                [1] = "ptcloudy",
                [2] = "ptrain",
                [3] = "ptheavyrain",
                [4] = "ptthunderstorm",
                [5] = "ptsnowslow",
                [6] = "ptDsnow",
                [7] = "ptblizzard",
                [8] = "ptsandfall",
                [9] = "ptsandstorm",
                [10] = "pthail",
                [11] = "ptrocksascending",
                [12] = "ptfog",
                [13] = "ptfog",
                [14] = "ptdark",
                [15] = "ptlightning",
                [16] = "ptlightsandstorm",
                [17] = "ptforestweather",
                [18] = "ptspotlight",
                [19] = "ptspotlight"
            };
            public static Dictionary<int, string> hgssweatherImageDict = new Dictionary<int, string>() {
                [0] = "hgssnormal",
                [1] = "hgssrain",
                [2] = "hgsssnow",
                [3] = "hgsshail",
                [4] = "hgssfog",
                [5] = "hgssdark",
                [6] = "hgssdark2"
            };
        }

        public static class ScriptMovements {
            public static string[] moveArray = new string[] {
                "[00]  None",
                "[01]  None",
                "[02]  Looking in all directions",
                "[03]  Walking around in all directions",
                "[04]  Walking Up, Down",
                "[05]  Walking Left, Right",
                "[06]  Looking Up, Left",
                "[07]  Looking Up, Right",
                "[08]  Looking Down, Left",
                "[09]  Looking Down, Right",
                "[10]  Looking Up, Down, Left",
                "[11]  Looking Up, Right, Down",
                "[12]  Looking Right, Left, Up",
                "[13]  Looking Right, Left, Down",
                "[14]  Facing Up",
                "[15]  Facing Down",
                "[16]  Facing Left",
                "[17]  Facing Right",
                "[18]  Counterclockwise spinning",
                "[19]  Clockwise spinning",
                "[20]  Running Up, Down",
                "[21]  L Run (Up, Right)",
                "[22]  Patrols Area, then stops",
                "[23]  Patrols Area, then stops",
                "[24]  L Run (Up, Right)",
                "[25]  Patrols Area, then stops",
                "[26]  Patrols Area, then stops",
                "[27]  Patrols Area, then stops",
                "[28]  L run (Right, Down)",
                "[29]  L run (Left, Up)",
                "[30]  Continuous patrolling",
                "[31]  Continuous patrolling",
                "[32]  L Run (Down, Right)",
                "[33]  L Run (Right, Up)",
                "[34]  Patrols Area, then stops",
                "[35]  Patrols Area, then stops",
                "[36]  L Run (Down, Left)",
                "[37]  Running Up, Left, Down, Right",
                "[38]  Running Down, Right, Up, Left",
                "[39]  Running Left, Down, Right, Up",
                "[40]  Running Right, Up, Left, Down",
                "[41]  Running Up, Right, Down, Left",
                "[42]  Running Down, Left, Up, Right",
                "[43]  Running Left, Up, Right, Down",
                "[44]  Running Right, Down, Left, Up",
                "[45]  Looking Up, Down",
                "[46]  Looking Right, Left",
                "[47]  ?",
                "[48]  Follow Hero",
                "[49]  Semi-circle spin (Down, Right, Up)",
                "[50]  ?",
                "[51]  Hidden Under Snow",
                "[52]  Hidden Under Snow",
                "[53]  Hidden Underground",
                "[54]  Hidden Under Grass",
                "[55]  Mimicks Player (moves within range)",
                "[56]  Mimicks Player (moves within range)",
                "[57]  Mimicks Player (moves within range)",
                "[58]  Mimicks Player (moves within range)",
                "[59]  Mimick's Player facing direction",
                "[60]  Mimick's Player facing direction",
                "[61]  Mimick's Player facing direction",
                "[62]  Mimick's Player facing direction",
                "[63]  Jogging on the spot",
                "[64]  Jogging on the spot",
                "[65]  Jogging on the spot",
                "[66]  Jogging on the spot",
                "[67]  Walking Right, Left",
                "[68]  Looking Right",
                "[69]  ?",
                "[70]  ?",
                "[71]  Looking Left"
            };
        }
        public static class CameraAngles {
            public static string[] DPPtCameraValues = new string[] {
                "[00] 3D Normal",
                "[01] 3D Top View (Higher than [12])",
                "[02] 3D Frontal Low (Wider than [15])",
                "[03] 3D Frontal",
                "[04] 2D Ortho",
                "[05] 3D Normal - Wide FOV",
                "[06] 3D Bird View",
                "[07] 3D Normal",
                "[08] 3D Bird View Far",
                "[09] 3D Frontal - Wide FOV",
                "[10] 3D Top View - Narrow",
                "[11] Normal 3D",
                "[12] 3D Top View",
                "[13] Frontal 3D",
                "[14] 3D Top View - Wide FOV",
                "[15] 3D Frontal Low"
            };
            public static string[] HGSSCameraValues = new string[] {
                "[00] 3D Top",
                "[01] 3D Front High",
                "[02] 3D Lower",
                "[03] 3D Frontal",
                "[04] 2D Top View",
                "[05] Normal 3D",
                "[06] 3D Normal",
                "[07] High 3D",
                "[08] 3D Top View",
                "[09] 3D Top View",
                "[10] 3D High Wide",
                "[11] 3D Frontal Wide",
                "[12] 3D Lower Close",
                "[13] 3D Full Frontal",
                "[14] 3D Top View",
                "[15] 2D Higher"
            };
        }
    }
}