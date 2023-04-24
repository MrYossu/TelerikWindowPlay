﻿namespace TelerikWindowPlay.Data;

public static class DataService {
  public static List<Charity> Charities = new() {
    new(1, "Skiles, Davis and Roob", "3644001249", "1358 Mills Plains Apt. 188", "West Chaya", "04280-4755"),
    new(2, "Johnston - Walter", "6023706317", "11644 Spencer View Suite 169", "North Osbaldo", "67770"),
    new(3, "Beahan, Casper and Ullrich", "5123825347", "8972 Raoul Island Suite 522", "Goyetteborough", "62798"),
    new(4, "Waelchi - Kemmer", "7703627607", "4493 Lubowitz Oval Apt. 095", "South Christellechester", "20243"),
    new(5, "Medhurst, Johns and Stokes", "0911142015", "7434 Montana Glens Apt. 392", "Port Briana", "35023-2451"),
    new(6, "Bechtelar, Schamberger and Kuhn", "7918745827", "1865 Bogisich Manor Suite 433", "Mortonberg", "21143-6448"),
    new(7, "Bode - Mertz", "3162279071", "259 Terrence Crossroad Suite 276", "VonRuedenside", "03400-4406"),
    new(8, "Borer, Farrell and Funk", "2887721794", "039 Wilma Freeway Apt. 285", "Jerdeton", "01842-3334"),
    new(9, "Zieme - Waelchi", "0906003057", "5558 Lebsack Village Apt. 894", "Lake Pinkie", "06270-7911"),
    new(10, "Lowe and Sons", "7925166167", "520 Smitham Mission Apt. 352", "Lake Abagailburgh", "40721-3847"),
    new(11, "Ortiz, Oberbrunner and O'Hara", "3742887372", "8981 Gustave Route Apt. 821", "New Zackeryview", "73873-2920"),
    new(12, "Gorczany, Hayes and Hills", "0355206224", "454 Casper Trafficway Suite 842", "Aliviahaven", "65842-3780"),
    new(13, "Stark - Russel", "2875526746", "26208 Stamm Extensions Apt. 195", "New Hailie", "68370"),
    new(14, "Goyette, Hickle and Runolfsson", "7902674463", "09269 Aglae Mountain Apt. 527", "Mannbury", "30584"),
    new(15, "Zboncak - Krajcik", "5178468632", "16474 Harold Terrace Apt. 240", "Roobchester", "22809-9950"),
    new(16, "Douglas Inc", "7256191211", "6685 Bednar Motorway Apt. 880", "Juanitafurt", "89341"),
    new(17, "Batz Group", "3168011075", "891 Balistreri Lodge Apt. 856", "Berneiceville", "00060-0388"),
    new(18, "Bartell - Walsh", "6997398607", "86669 Hellen Glens Suite 514", "Stephaniemouth", "84508"),
    new(19, "Green and Sons", "8274466735", "528 Jacobs Island Suite 807", "New Mayaberg", "46222"),
    new(20, "Wyman - Hettinger", "4646424011", "000 Leonardo Throughway Apt. 577", "Stephaniafurt", "66696"),
    new(21, "Schuster, Hackett and Buckridge", "3715063685", "2855 Torphy Expressway Suite 571", "Dietrichfort", "32761"),
    new(22, "Mosciski LLC", "1078059883", "370 Murray Lake Apt. 345", "Gutkowskiborough", "88606"),
    new(23, "Abbott Group", "2427858649", "38126 Lorena Terrace Suite 644", "East Mikayla", "14615-9053"),
    new(24, "Kautzer, Upton and Murray", "3195492804", "28724 Justyn Circle Apt. 072", "Juvenalfort", "80372"),
    new(25, "Johnston LLC", "8078872526", "166 Heidenreich Hills Suite 101", "Jaydebury", "67181-1605"),
    new(26, "Boyle - Bradtke", "8583019368", "677 Darryl Lakes Suite 868", "East Kaelastad", "42911-7509"),
    new(27, "Kuphal, Lowe and Spencer", "7896599314", "747 Schmitt Mill Suite 928", "New Josiestad", "70367-4057"),
    new(28, "Keebler, Nolan and Hermiston", "4652383621", "63499 Streich Stravenue Apt. 019", "West Dax", "28414-7184"),
    new(29, "O'Keefe, Simonis and Kassulke", "2872889295", "091 Ritchie Passage Apt. 752", "New Grant", "21807-8789"),
    new(30, "Ritchie LLC", "7443224316", "207 Luettgen Groves Suite 463", "Karinestad", "71062"),
    new(31, "Kling - Bode", "3386681442", "1612 Blaze Mountains Apt. 037", "North Marian", "11419-0314"),
    new(32, "Waters Inc", "7814237505", "1117 Geovanny Overpass Suite 326", "Doylemouth", "90866"),
    new(33, "Bauch - Olson", "9356878396", "5923 Wiza Island Suite 050", "North Judd", "37277-6399"),
    new(34, "Pfannerstill Group", "1929952601", "491 Tess Valleys Apt. 014", "Mustafahaven", "58885"),
    new(35, "Schmitt - Orn", "7204858805", "07009 Milford Court Apt. 179", "Greenmouth", "42055-6764"),
    new(36, "Carter LLC", "0318842629", "4408 Lemke Ville Suite 732", "Lake Winstonhaven", "44735"),
    new(37, "Hickle - MacGyver", "7305644908", "05579 Karlee Stravenue Suite 868", "New Chyna", "81416-5492"),
    new(38, "Little Inc", "0719918779", "956 Earline Coves Suite 699", "South Claud", "07334"),
    new(39, "Schimmel, Rohan and Treutel", "8583858685", "789 Bernier Union Apt. 378", "Kundeport", "05016-4091"),
    new(40, "Mante, D'Amore and O'Hara", "9088063562", "0573 Javonte Green Apt. 764", "East Bernadettefurt", "94513"),
    new(41, "Vandervort LLC", "6421562107", "01227 Schowalter Lights Suite 970", "South Madisentown", "88570"),
    new(42, "Homenick, McGlynn and O'Conner", "8443599480", "6767 Gregory Green Suite 890", "East Anahitown", "68024-3231"),
    new(43, "O'Reilly and Sons", "7664227756", "4709 Runolfsdottir Burg Suite 098", "South Lyricstad", "33544"),
    new(44, "Waters - Hand", "8848459648", "978 O'Conner Tunnel Suite 084", "Greenfelderview", "83348-8525"),
    new(45, "Schulist Group", "1688996554", "05478 Kennedi Motorway Suite 904", "Lake Hortense", "57537-8522"),
    new(46, "Glover - Kuvalis", "9054749968", "93498 Halvorson Shores Apt. 969", "West Emeliamouth", "42922-9744"),
    new(47, "Huel, Brakus and Hills", "7181782490", "00153 Fiona Mission Suite 540", "Kirkchester", "63610-5786"),
    new(48, "Goodwin, Rempel and Kautzer", "4001483002", "1000 Murazik Vista Suite 019", "East Jazmin", "27786-8440"),
    new(49, "O'Kon - Altenwerth", "5371364232", "75082 Dawn Extension Apt. 686", "West Mohamed", "01531-0011"),
    new(50, "Little - Senger", "9240273930", "13632 Dahlia Burg Apt. 183", "South Aurelia", "87937-1489"),
    new(51, "Hauck - Hane", "0012586202", "00356 Kian Plains Suite 242", "Josephineborough", "35821"),
    new(52, "Daniel Group", "3711356679", "34508 Cremin Grove Suite 270", "North Lonzo", "59365"),
    new(53, "Blick Group", "8171706693", "60902 Rice Curve Apt. 449", "Marqueschester", "41455-1242"),
    new(54, "Rutherford - Paucek", "7069673757", "10532 Arne Motorway Apt. 077", "Lake Aniyatown", "90630"),
    new(55, "Sipes - Mueller", "2644886413", "227 Graham Roads Suite 074", "Hermannland", "83781"),
    new(56, "Larson - Mraz", "4331050924", "0341 Yundt Tunnel Apt. 147", "New Mosechester", "80258-8103"),
    new(57, "Raynor - Fritsch", "6098292947", "6262 Ullrich Mountains Apt. 924", "West Gunnerfort", "28388-3048"),
    new(58, "Reichert - Champlin", "4161987358", "9423 Herzog Parkways Apt. 408", "East Gregg", "25185"),
    new(59, "Gerhold LLC", "8527552876", "670 Wiegand Spurs Apt. 638", "Ricefurt", "55216"),
    new(60, "Lakin, McLaughlin and Boyle", "2690331553", "6460 Donald Forest Apt. 432", "South Dawn", "02363-8745"),
    new(61, "Schowalter - Lind", "5143870857", "142 Elody Spurs Apt. 791", "Hesselstad", "57433"),
    new(62, "Murphy - Macejkovic", "1494777315", "344 Kshlerin Estates Apt. 679", "West Beverlyside", "57528"),
    new(63, "Brown, Swift and Murazik", "7876440718", "8484 Moen Squares Suite 290", "Littelmouth", "32833"),
    new(64, "Schneider LLC", "4343329222", "802 Ledner Pine Suite 086", "New Elvera", "86485"),
    new(65, "Pacocha - Shanahan", "4709302657", "7820 Shields Spring Suite 110", "North Joanny", "15069"),
    new(66, "Schaefer - Quitzon", "2413385114", "2701 Precious Lights Apt. 168", "North Milliefort", "79489-6093"),
    new(67, "Walter Group", "7116596624", "98295 Vladimir River Suite 448", "O'Keefehaven", "43143"),
    new(68, "Bayer and Sons", "1502334065", "5380 Eric Forge Suite 811", "Collinston", "87904"),
    new(69, "Terry, Wolf and Larson", "1507805624", "59998 Amiya Freeway Apt. 884", "Hillsshire", "19895"),
    new(70, "Shanahan Group", "8212596863", "58307 Edison Squares Apt. 393", "North Benedictshire", "06219"),
    new(71, "Daniel - Dach", "3468907537", "72875 Frami Brook Apt. 343", "New Edwinaport", "02660"),
    new(72, "Bernhard, Rodriguez and Hickle", "5551363017", "427 Gerlach Oval Suite 832", "Port Davon", "98304"),
    new(73, "Krajcik Group", "4864034354", "6231 Stamm Greens Suite 180", "New Vickyton", "29179-9277"),
    new(74, "Smitham LLC", "9958606443", "3458 Brekke Landing Apt. 965", "New Dangeloburgh", "11576"),
    new(75, "Greenholt, Auer and Effertz", "9533509954", "86990 Trantow View Suite 061", "Solonhaven", "44594"),
    new(76, "Gorczany - Schowalter", "2981415072", "34972 Hahn Orchard Apt. 382", "Rathview", "53293"),
    new(77, "O'Conner, Goodwin and Baumbach", "3739997668", "408 Kunde Ferry Suite 503", "Novaberg", "09142-3152"),
    new(78, "Abernathy - Farrell", "7342508792", "0934 Bashirian Pines Apt. 901", "Braedenton", "33999-0572"),
    new(79, "Hammes - Borer", "9501038383", "6639 Tremblay Neck Suite 611", "Orrintown", "83920"),
    new(80, "Luettgen, Bechtelar and Rutherford", "9059549450", "83691 McLaughlin Mountain Apt. 566", "Goyetteport", "87815"),
    new(81, "Grady - Dooley", "4424695433", "415 Brain Locks Apt. 235", "Yostberg", "30554"),
    new(82, "Emmerich and Sons", "2793707782", "1805 Reinger Route Apt. 936", "East Elliestad", "22973"),
    new(83, "Langworth, Koelpin and Littel", "9799669217", "79932 Gabriel Light Apt. 028", "East Doyle", "32194-5028"),
    new(84, "Altenwerth, Mueller and McCullough", "3056996005", "8902 Littel Isle Suite 302", "East Cynthia", "45470-4293"),
    new(85, "Hegmann, Conn and Daniel", "8739142363", "183 Mariano Lodge Apt. 731", "North Stephen", "83491"),
    new(86, "MacGyver Group", "1296377754", "8429 Savanna Trace Suite 994", "West Vanmouth", "03991"),
    new(87, "Hessel - Huel", "0488513445", "4886 Pouros Lodge Suite 033", "New Clevelandborough", "79005-3044"),
    new(88, "Beahan - Bahringer", "7687660139", "26587 Kristy Dam Suite 795", "Dimitriton", "45782-6560"),
    new(89, "Daniel Group", "7446007688", "19784 Mraz Burg Suite 445", "Krajcikhaven", "68476-6263"),
    new(90, "Turcotte Inc", "0355755142", "3453 Kristopher Mill Apt. 224", "South Suzanneshire", "81405"),
    new(91, "Batz - Crona", "3052200808", "5975 Zakary Drive Suite 854", "Aufderharville", "79463"),
    new(92, "Kuphal - Heaney", "8885624296", "123 Hand Throughway Apt. 500", "Port Sashamouth", "33440"),
    new(93, "Rodriguez Inc", "9803818287", "579 Ryan Coves Apt. 038", "Rogahnchester", "21575"),
    new(94, "Hagenes Inc", "1300876159", "38185 Parisian Alley Apt. 426", "Port Archborough", "65758"),
    new(95, "Lubowitz, Leffler and Stiedemann", "3295371610", "646 Beatty Walks Apt. 234", "East Bridgetburgh", "04414"),
    new(96, "Nitzsche Group", "8448665003", "07906 Huel Creek Suite 647", "Lake Schuylerbury", "73266"),
    new(97, "Wisozk LLC", "4182971882", "6493 Ziemann Row Suite 594", "North Celestinohaven", "09087-1286"),
    new(98, "Pouros - Bashirian", "4238896329", "8258 Rupert Unions Apt. 673", "Connchester", "87468-0667"),
    new(99, "Quigley, Lindgren and Breitenberg", "3169254796", "63425 Grimes Squares Suite 431", "Ransomfort", "04047"),
    new(100, "Kilback, Kertzmann and Fritsch", "4454055153", "4828 Hyatt Locks Suite 707", "Timmothyfort", "50409"),
  };

  public static List<Customer> Customers = new() {
    new(1, "Bianka", "Lehner", "Samson_Schmidt0@yahoo.com", "647 Oren Heights Apt. 902", "Robbiechester", "85108"),
    new(2, "Jeramy", "Welch", "Dulce19@gmail.com", "9952 Swaniawski Parks Apt. 524", "Howellstad", "21307"),
    new(3, "Juliet", "Kautzer", "Aaliyah_Fay@gmail.com", "11798 June Ville Suite 476", "Runolfsdottirhaven", "18418"),
    new(4, "Edmond", "Armstrong", "Trystan.Balistreri@hotmail.com", "9445 Rosanna Underpass Apt. 911", "Rohanmouth", "47506"),
    new(5, "Viviane", "Wyman", "Laury_McClure96@hotmail.com", "94601 Cummings Ranch Apt. 199", "Volkmanbury", "34011-7108"),
    new(6, "Freeda", "Kub", "Katlyn83@yahoo.com", "787 Tromp Views Apt. 470", "East Elyssabury", "76619"),
    new(7, "Fabiola", "Sporer", "Laurine.Block33@hotmail.com", "16523 Reichel Ford Suite 522", "Kaylaberg", "72578-2492"),
    new(8, "Raoul", "Wunsch", "Caleigh64@yahoo.com", "898 Bruen Road Apt. 012", "Port Claudiastad", "77984"),
    new(9, "Chandler", "Leffler", "Armando.Nicolas@yahoo.com", "42559 Hartmann Skyway Suite 050", "South Laurettaville", "45092-8266"),
    new(10, "Mossie", "Lubowitz", "Randi29@hotmail.com", "24584 Pedro Spur Apt. 197", "Jonathonchester", "74432"),
    new(11, "Matilde", "Breitenberg", "Lawson_Rogahn@hotmail.com", "1373 Parisian Hills Suite 752", "Patriciashire", "38400-0175"),
    new(12, "Tanya", "Pfeffer", "Claudine93@yahoo.com", "15352 Jace Brook Suite 166", "South Gage", "03119"),
    new(13, "Camren", "Gislason", "Shaun.Grady@yahoo.com", "9967 Sven Branch Apt. 030", "Evansbury", "29767"),
    new(14, "Lura", "Bergnaum", "Augustine.Hirthe76@hotmail.com", "43427 Dannie Parkways Apt. 305", "Wolffville", "14183"),
    new(15, "Bonnie", "Zieme", "Callie31@hotmail.com", "46626 Meredith Valleys Apt. 277", "Sybleborough", "68951"),
    new(16, "Ottilie", "Thompson", "Mylene_Weimann4@hotmail.com", "9977 Streich Shores Apt. 437", "South Arvel", "62439-3595"),
    new(17, "Alexandrine", "Rosenbaum", "Rogelio.Schultz@gmail.com", "1841 Aisha Underpass Suite 986", "Ernsertown", "69371"),
    new(18, "Wilburn", "Thompson", "Reid_Bosco89@hotmail.com", "808 Mark Centers Suite 230", "New Aubreystad", "96552-7469"),
    new(19, "Rory", "Walter", "Jovanny.Kihn@hotmail.com", "66772 Brielle Corners Apt. 199", "Streichfort", "36339-1763"),
    new(20, "Eino", "Volkman", "Stacy.Parker41@hotmail.com", "82212 Devyn Trail Apt. 336", "Meganetown", "72469"),
    new(21, "Anabel", "Reinger", "Jaycee70@yahoo.com", "4045 Jevon Center Apt. 824", "Port Serena", "98782-7546"),
    new(22, "Lisette", "Skiles", "Ronaldo.Konopelski49@gmail.com", "594 Crona Squares Apt. 853", "North Borisshire", "74397"),
    new(23, "Bonnie", "Labadie", "Annie22@yahoo.com", "22298 Dickinson Stream Suite 381", "Immanuelfort", "32313"),
    new(24, "Oral", "McClure", "Ewell_Miller@gmail.com", "2552 Cartwright Key Suite 815", "Hacketthaven", "12720"),
    new(25, "Mathew", "Wilderman", "Arturo_Rosenbaum72@yahoo.com", "1272 Lenna Falls Suite 963", "Lake Wiltonstad", "48591"),
    new(26, "Bonnie", "Mitchell", "Jon60@hotmail.com", "750 Okey Landing Apt. 872", "Lake Leslie", "48302-0470"),
    new(27, "Gracie", "Grady", "Cooper71@gmail.com", "94140 Rolfson Ports Suite 703", "Lourdesfort", "02031-8549"),
    new(28, "Jaylen", "Langosh", "Marta.Zieme74@hotmail.com", "31188 Schneider Pass Apt. 221", "East Ellisberg", "30385"),
    new(29, "Ferne", "Robel", "Reid.Wilderman86@yahoo.com", "10848 Gutmann Mill Suite 860", "Port Leopoldoville", "78433"),
    new(30, "Clotilde", "Sanford", "Annamae.Ledner@gmail.com", "8945 Rice Knoll Apt. 824", "West Ana", "00388-8645"),
    new(31, "Ernestina", "Barrows", "Lance_Jenkins@gmail.com", "60024 Nels Ford Suite 173", "New Glennieton", "93729-1346"),
    new(32, "Assunta", "Runolfsdottir", "Dolores_Hettinger@hotmail.com", "2469 Wuckert Plaza Suite 997", "Ratkeport", "63877-5615"),
    new(33, "Eusebio", "Zulauf", "Lysanne_Murphy@hotmail.com", "954 Dock Oval Suite 978", "Lake Magnusview", "99470-5991"),
    new(34, "Jordane", "Fisher", "Travis_Bruen49@gmail.com", "06214 Kuhn Coves Suite 402", "Carolinamouth", "26431-8108"),
    new(35, "Michelle", "Hodkiewicz", "Jakayla21@hotmail.com", "8954 Batz Throughway Apt. 948", "Kaileybury", "85493"),
    new(36, "Melany", "Mertz", "Bart36@yahoo.com", "70507 Laura Stream Apt. 025", "Langworthhaven", "74878-3219"),
    new(37, "Jay", "Wyman", "Kamron96@yahoo.com", "345 Block Plaza Suite 054", "Schummton", "32023-9133"),
    new(38, "Zion", "Leffler", "Elmore_Heidenreich64@yahoo.com", "5554 Denesik Lights Apt. 489", "Nienowmouth", "08657"),
    new(39, "Moises", "Quitzon", "Cornell.Kling3@hotmail.com", "468 Eliseo Pine Suite 202", "West Charley", "03761"),
    new(40, "Ebba", "Koepp", "Kay96@hotmail.com", "524 Abshire Streets Suite 238", "Juniustown", "99207-4439"),
    new(41, "Eleonore", "Gibson", "Kailee16@gmail.com", "27891 Kub Points Apt. 866", "North Melbabury", "60158-3094"),
    new(42, "Cleveland", "Dickens", "Korey54@gmail.com", "443 Weimann Garden Suite 024", "Drakemouth", "86893-2403"),
    new(43, "Katherine", "Turner", "Sabrina53@hotmail.com", "8275 Littel Lodge Apt. 631", "Veronicaland", "72795"),
    new(44, "Sebastian", "Johnston", "Alena_Emard68@hotmail.com", "77691 Kertzmann Creek Apt. 715", "Lake Esteban", "66817-6620"),
    new(45, "Mohammad", "Shanahan", "Johnathon85@hotmail.com", "089 Berge Port Apt. 576", "Grahambury", "00915"),
    new(46, "Christy", "Lind", "Gunnar_Shanahan@gmail.com", "91009 Heathcote Roads Apt. 326", "Port Jules", "34498-2033"),
    new(47, "Brooke", "Jakubowski", "Cleveland.Rau@yahoo.com", "252 Millie Parks Apt. 185", "North Emory", "02734"),
    new(48, "Duncan", "Rath", "Arthur_Harber@yahoo.com", "5799 Nicholas Ferry Suite 671", "South Jakechester", "27188-6644"),
    new(49, "Terrill", "Wehner", "Dina.Russel6@hotmail.com", "33742 Colton Garden Apt. 333", "West Celestinehaven", "98149-2565"),
    new(50, "Eli", "Heaney", "Scot.Borer@hotmail.com", "1658 Kianna Trafficway Suite 550", "Donnychester", "65897"),
    new(51, "Jammie", "Emard", "Modesta29@gmail.com", "6149 Wilford Trafficway Suite 380", "Leannontown", "85161"),
    new(52, "Ned", "Leuschke", "Turner.McDermott86@gmail.com", "14518 Labadie Loop Suite 072", "Lake Amarafurt", "64527"),
    new(53, "Javier", "Streich", "Camille.Torp@hotmail.com", "081 Boehm Burgs Suite 309", "Maximiliantown", "25741"),
    new(54, "Wilton", "Moore", "Jon.Conroy82@gmail.com", "028 Hoeger Cliffs Apt. 181", "Stiedemanntown", "70415-9601"),
    new(55, "Nona", "Dare", "Lea.Pollich32@gmail.com", "234 Hillary Key Apt. 643", "New Carmelabury", "89560"),
    new(56, "Arlene", "Donnelly", "Zora.Gleason@hotmail.com", "6925 Jacobson Islands Apt. 678", "West Micaelaport", "98131"),
    new(57, "Fernando", "Tromp", "Janae.Berge1@gmail.com", "8680 Nicolas Haven Apt. 507", "Eldonberg", "73461-4751"),
    new(58, "Cielo", "Huels", "Layne_Kozey20@yahoo.com", "27046 Monahan Turnpike Apt. 988", "West Elnaside", "79618"),
    new(59, "Rubie", "Kling", "Cesar_Pfannerstill@hotmail.com", "303 Bettye Cliff Apt. 378", "North Theodoraton", "89782"),
    new(60, "Maurice", "Kunze", "Elouise37@hotmail.com", "718 Hammes Light Suite 288", "East Concepcionview", "42076"),
    new(61, "Ervin", "Tremblay", "Ransom58@hotmail.com", "29836 Henry Islands Suite 736", "Pfefferview", "37816"),
    new(62, "Dorian", "Fritsch", "Kacey13@gmail.com", "919 Trycia Drives Apt. 930", "Hazleport", "85151"),
    new(63, "Alexane", "Donnelly", "Leonel_DuBuque@yahoo.com", "62970 Chyna Haven Suite 408", "North Sibylberg", "02362"),
    new(64, "Christiana", "Mohr", "Ahmed44@yahoo.com", "021 Rutherford Springs Suite 568", "East Shaynaton", "96451"),
    new(65, "Rachael", "Davis", "Alberto_Schmeler@gmail.com", "8082 Breitenberg Ports Suite 263", "Gutkowskiland", "19401-8561"),
    new(66, "Jazmyn", "Barrows", "Emory.Stehr40@yahoo.com", "6087 Alison Mountain Suite 798", "East Anahi", "66483"),
    new(67, "Hobart", "Cummings", "Charlene18@yahoo.com", "4862 Bridget Stravenue Suite 659", "Ardithborough", "30486-3524"),
    new(68, "Nya", "Legros", "Everardo.Dooley@gmail.com", "1022 Jane Hollow Apt. 747", "Klockomouth", "36902-2844"),
    new(69, "Margarita", "Marvin", "Kaitlin.Gottlieb75@gmail.com", "807 Hand Shoal Suite 605", "South Halbury", "14299"),
    new(70, "Cale", "Langworth", "Duane.Swaniawski@gmail.com", "5127 Coralie Shores Suite 595", "Lake Hipolitoport", "74832"),
    new(71, "Sedrick", "Cassin", "Shakira.McDermott@hotmail.com", "8759 Bergnaum Stream Suite 294", "Murielburgh", "48650"),
    new(72, "Theo", "Herman", "Iva_Stark@hotmail.com", "8963 Hamill Parkway Suite 840", "New Lornafurt", "54460"),
    new(73, "Brandt", "Macejkovic", "Cydney85@yahoo.com", "2469 Reichert Stravenue Apt. 057", "Fritschborough", "20227-5610"),
    new(74, "Myrtie", "Kemmer", "Verlie.Wolf@hotmail.com", "990 Buckridge Street Apt. 673", "New Clovis", "82754-8718"),
    new(75, "Tessie", "Feil", "Violette9@gmail.com", "77234 Deondre Spur Apt. 132", "Kristamouth", "00654"),
    new(76, "Jared", "Howell", "Zachariah85@yahoo.com", "66822 Eino Stream Apt. 795", "Imeldamouth", "64018"),
    new(77, "Dandre", "Kemmer", "Shayna_Goodwin@hotmail.com", "9761 Lueilwitz Rest Suite 263", "Sigmundland", "14346"),
    new(78, "Elda", "Ziemann", "Eveline_Auer17@gmail.com", "3908 Aurelie Plain Suite 760", "Gulgowskiburgh", "99974-3782"),
    new(79, "Paxton", "Windler", "Tiana17@yahoo.com", "74297 Jake Stravenue Suite 360", "New Justonborough", "18558"),
    new(80, "Eunice", "Volkman", "Domenica74@gmail.com", "24209 Ricardo Camp Apt. 296", "Klingfort", "28234"),
    new(81, "Lavinia", "Herzog", "Felton13@yahoo.com", "55549 Norberto Spring Suite 998", "Lake Carmenville", "23351-4992"),
    new(82, "Lelia", "Welch", "Immanuel_Mueller@gmail.com", "784 Schultz Harbor Apt. 639", "Watsicahaven", "31673"),
    new(83, "Shannon", "Ullrich", "Jarod70@gmail.com", "3918 Homenick Shore Suite 130", "Lake Joannie", "27192-8244"),
    new(84, "Carey", "Crist", "Lacey44@gmail.com", "125 Conn Creek Suite 903", "Franciscahaven", "92556"),
    new(85, "Stephon", "Lind", "Marcus.Kiehn@hotmail.com", "73044 Adolf Haven Suite 457", "Augustmouth", "05947"),
    new(86, "Valentin", "Schoen", "Eden_Corwin@yahoo.com", "3269 Shirley Circle Suite 189", "Norenefurt", "25639-7912"),
    new(87, "Arno", "Schumm", "Bethany19@hotmail.com", "57556 Joseph Run Apt. 324", "West Bertafort", "01218-2064"),
    new(88, "Doyle", "Schamberger", "Everardo58@yahoo.com", "9102 Kshlerin Falls Apt. 324", "Adahton", "18874"),
    new(89, "Christ", "Trantow", "Johnnie25@hotmail.com", "990 Koepp Brooks Suite 584", "Port Elias", "55845"),
    new(90, "Kim", "Connelly", "Gaylord76@gmail.com", "0115 Bruen Via Apt. 405", "North Marvinside", "57295-8148"),
    new(91, "Alexis", "Cartwright", "Jaquan97@gmail.com", "70601 Joyce Walks Apt. 295", "Aubreeview", "29179"),
    new(92, "Zack", "Beier", "Donavon83@yahoo.com", "69229 O'Kon Fort Suite 959", "Brendenport", "33412"),
    new(93, "Audra", "Wintheiser", "Samanta1@hotmail.com", "497 Diamond Centers Apt. 067", "Port Desireeburgh", "23748-7418"),
    new(94, "Liliana", "Hills", "Nicklaus.Pouros28@yahoo.com", "8021 Heathcote Circles Suite 360", "South Sigurd", "91560"),
    new(95, "Shanie", "Kuhic", "Jonathon.Schuppe@yahoo.com", "936 Schuster Cliff Suite 591", "North Frederic", "73131"),
    new(96, "Ethelyn", "Stanton", "Shaylee.Ernser@gmail.com", "4327 Tristin Circles Apt. 041", "Lavadaport", "64358"),
    new(97, "Mauricio", "Satterfield", "Art_Koepp26@yahoo.com", "9631 Ritchie Rest Apt. 109", "South Melyssa", "98152"),
    new(98, "Nadia", "Macejkovic", "Theodora.Bogisich80@yahoo.com", "39607 Favian Corners Suite 442", "South Ewaldview", "66254"),
    new(99, "Carson", "Braun", "Cristobal.Nienow99@yahoo.com", "76498 Wiley Crescent Apt. 259", "West Novaton", "01325-4159"),
    new(100, "Lea", "McGlynn", "Cletus3@gmail.com", "996 Sidney Knoll Suite 772", "Emmanuelmouth", "52997-2537"),
  };
}