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
    public Customer(int id, string salutation, string surname) {
      Id = id;
      Salutation = salutation;
      Surname = surname;
    }

    public int Id { get; set; }
    public string Salutation { get; set; }
    public string Surname { get; set; }
  }

  public static List<Customer> Customers = new() {
    new(5, "Dayan", "Grynhaus"),
    new(6, "Rabbi", "Grynhaus"),
    new(10, "Rabbi", "Weis"),
    new(11, "Yoely", "Greenhut"),
    new(12, "Rabbi", "Kramer"),
    new(14, "Mr", "Salzman"),
    new(15, "Dr", "Levenson"),
    new(21, "Mr", "Neumann"),
    new(23, "Shlomo", "Katanka"),
    new(44, "Reb Yankel", "Wolf"),
    new(50, "Shloime", "Grynhaus"),
    new(62, "Mr", "Frenkel"),
    new(86, "David", "Hammelburger"),
    new(97, "M", "Gross"),
    new(115, "Yidi", "Grunsfeld Fine Foods"),
    new(128, "Reb Aryeh", "Ehrentreu"),
    new(134, "Yaki", "Halpern"),
    new(162, "Dr Yodaiken", "Yodaiken"),
    new(199, "Shuly Salzman", "City View Manchester Ltd"),
    new(208, "Johny", "Marks/Orzel"),
    new(210, "Mr Itzkovitz", "Waterpark Properties Ltd"),
    new(220, "Rabbi Kraus", "English Holdings C.T."),
    new(250, "Mr Bamberger", "Bamberger"),
    new(256, "Reb Aron", "Wacks"),
    new(267, "Dovy", "Brandeis"),
    new(301, "Reb Yankel", "Adler"),
    new(305, "For mikvah Acc", "Horwich"),
    new(1220, "Mr D Schwartz", "Gableton LTD"),
    new(53, "Fay", "Muller"),
    new(54, "M", "Friedman"),
    new(55, "MZ", "Jung"),
    new(79, "Myer", "Heilpern"),
    new(26, "Yossi", "Brandeis"),
    new(128, "Tzviki", "Eherentreu"),
    new(38, "Osher", "Goldman"),
    new(108, "Reb Shia Oizer", "Halpern"),
    new(109, "Yosef Dov", "Cohen"),
    new(111, "Rafi", "Miller"),
    new(770, "Chaim", "Greenberg"),
    new(127, "Menachem", "Schleider"),
    new(150, "Binyomin", "Katz"),
    new(187, "Elya", "Kosher Direct Ltd"),
    new(225, "Avrohom", "Brunner"),
    new(175, "Mr & Mrs Berkley", "The Carmona CT"),
    new(265, "Danny", "Lopian"),
    new(8, "Reb Berish", "Berger"),
    new(295, "Reb Noach", "Fletcher"),
    new(3, "Yona", "Emanuel"),
    new(319, "Mr Sluckis", "Sluckis"),
    new(320, "Shaye", "Kernkraut"),
    new(323, "Pinny", "Issler"),
    new(325, "Danny", "Schleider"),
    new(356, "J", "Steinberg"),
    new(361, "Yiddi", "Braceiner"),
    new(362, "Yedidya", "Heilpern"),
    new(364, "Shmuli", "Kaufman"),
    new(368, "Buchy", "Glick"),
    new(370, "Daniel", "Walker"),
    new(376, "Yony", "Reich"),
    new(378, "Mr Weiler", "Charlfords Limited"),
    new(385, "Yosef", "March"),
    new(384, "Reb Yoel", "Weiss"),
    new(394, "Aryeh", "Roberts"),
    new(398, "Shimon", "Orzel"),
    new(402, "Mordche", "Kaufman"),
    new(405, "Dovid", "Hochhauser"),
    new(406, "Roger", "Baker"),
    new(407, "Simon", "Grant"),
    new(408, "Leo", "Klein"),
    new(410, "Dan", "Communications Ltd"),
    new(412, "Motty Broder", "Affiliated Utilities Ltd"),
    new(417, "David", "Levine"),
    new(4, "E", "Rosen"),
    new(420, "Simon", "Fine"),
    new(425, "Menachem Dov", "Yodaiken"),
  };

  #endregion
}