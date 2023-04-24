namespace TelerikWindowPlay.Data;

public static class DataService {
  #region General

  public class BaseEntity {
    public bool Visible { get; set; }
  }

  #endregion

  #region Charities

  public class Charity : BaseEntity {
    public Charity(int id, string name, string number) {
      Id = id;
      Name = name;
      Number = number;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string Number { get; set; }
  }

  public static List<Charity> Charities = new() {
    new(7, "Pinto Kolel", "05346702"),
    new(8, "Torah Movement Network", "29932565"),
    new(9, "Project Seed", "02803181"),
    new(10, "Ladies Relief Commitee", "00013398"),
    new(12, "Centre For Torah Education Trust", "02325208"),
    new(13, "Yeshivas Shaarei Torah", "08325480"),
    new(14, "Friends of Asos Chesed", "20097136"),
    new(17, "Noam Shabbos Association", "13360082"),
    new(18, "Yad Toiva Trust", "00598134"),
    new(19, "Kayama Ltd", "68488903"),
    new(21, "Chasdei Yoel", "83956202"),
    new(22, "Talmud Torah Chinuch Norrim", "63110254"),
    new(23, "Kollel Tiferes Sholom", "00276110"),
    new(24, "Keren Hachesed", "48133073"),
    new(25, "Shaare Zedek UK", "31622927"),
    new(26, "Shellix Co. Ltd", "04738438"),
    new(27, "Jewish Marriage Education", "00350252"),
    new(28, "Collel Chibath Yerushalayim", "40237523"),
    new(29, "Keren LDovid Educational Trust", "20190474"),
    new(30, "Manchester Charitable Trust Limited", "80158399"),
    new(32, "Yeshiva Lzeirim", "20231804"),
    new(34, "CMA Trust", "00050651"),
    new(35, "Norwood Ravenswood", "20619094"),
    new(37, "Matono", "86055046"),
    new(38, "Craven Walk Charitable Trust", "63540894"),
    new(39, "Ahavas Shalom Trust", "90941263"),
    new(40, "Beis Hamedrash Hachodosh", "10027080"),
    new(41, "Manchester Junior Girls School", "05400952"),
    new(42, "Academy for Rabbinical Research", "11124594"),
    new(43, "Beis Yaakov Jewish High School", "02415304"),
    new(44, "Simcha Gemach", "13172901"),
    new(45, "Chevras Ezras Nitzrochim", "56751084"),
    new(50, "Child Resettlement Fund-Emunah", "60076163"),
    new(52, "Gateshead Jewish Primary School", "40607215"),
    new(54, "Bobov Foundation", "31108530"),
    new(55, "Mekor Boruch", "10010994"),
    new(56, "Belz", "62447573"),
    new(57, "Kollel Zichron Shaul", "10080187"),
    new(58, "Beth Yaakov Seminary For Girls", "17831865"),
    new(59, "Mifal Temicha Lenesuin", "24498085"),
    new(60, "MANCHESTER HACHNOSAS KALLOH FUND", "60866938"),
    new(61, "Jewish Ladies Aid Society", "80523550"),
    new(62, "Beis Hamedrash Shaarei Tefilah", "42419883"),
    new(63, "Reb Hershel Goldstein Memorial Fund", "10489468"),
    new(65, "Beis Malka Girls School", "63920743"),
    new(67, "Bnos Yisroel Club", "10064962"),
    new(68, "Central And North Manchester Synagogue", "10379584"),
    new(69, "Manchester Talmudical College", "65861417"),
    new(70, "Yeshivas Ezras Torah", "17831423"),
    new(71, "Bikur Cholim & Gemiluth Chesed Trust", "64356523"),
    new(72, "Manchester Jewish Community Care", "40627283"),
    new(73, "Kolel Nethivoth Hatalmud", "67187212"),
    new(75, "TMimei Lev", "80113352"),
    new(77, "Gateshead Jewish Academy for Girls", "90264040"),
    new(79, "Kanfei Yona Charitable Trust", "20423900"),
    new(80, "House of Gur", "17796911"),
    new(81, "Broom Foundation", "41465764"),
  };

  #endregion

  #region Customers

  public class Customer : BaseEntity {
    public Customer(int id, string firstName, string surname, string email, string address, string city, string postcode) {
      Id = id;
      FirstName = firstName;
      Surname = surname;
      Email = email;
      Address = address;
      City = city;
      Postcode = postcode;
    }

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string Postcode { get; set; }
  }

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

  #endregion
}