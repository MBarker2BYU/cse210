// ***********************************************************************
// Assembly        : OnlineOrdering
// Author            : Matthew D. Barker
// Created           : 03-24-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-24-2025
// ***********************************************************************
// <copyright file="Country.cs" company="OnlineOrdering">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace OnlineOrdering.Enums;

/// <summary>
/// Enum Country
/// </summary>
public enum Country
{
    [CountryInfo(Code = "--", PhoneCode = -1,  Name = "None")]
    None,
    /// <summary>
    /// The afghanistan
    /// </summary>
    [CountryInfo(Code = "af", PhoneCode = 93, Name  = "Afghanistan")]
    Afghanistan,
    /// <summary>
    /// The albania
    /// </summary>
    [CountryInfo(Code = "al", PhoneCode = 355, Name  = "Albania")]
    Albania,
    /// <summary>
    /// The algeria
    /// </summary>
    [CountryInfo(Code = "dz", PhoneCode = 213, Name  = "Algeria")]
    Algeria,
    /// <summary>
    /// The andorra
    /// </summary>
    [CountryInfo(Code = "ad", PhoneCode = 376, Name  = "Andorra")]
    Andorra,
    /// <summary>
    /// The angola
    /// </summary>
    [CountryInfo(Code = "ao", PhoneCode = 244, Name  = "Angola")]
    Angola,
    /// <summary>
    /// The antarctica
    /// </summary>
    [CountryInfo(Code = "aq", PhoneCode = 672, Name  = "Antarctica")]
    Antarctica,
    /// <summary>
    /// The argentina
    /// </summary>
    [CountryInfo(Code = "ar", PhoneCode = 54, Name  = "Argentina")]
    Argentina,
    /// <summary>
    /// The armenia
    /// </summary>
    [CountryInfo(Code = "am", PhoneCode = 374, Name  = "Armenia")]
    Armenia,
    /// <summary>
    /// The aruba
    /// </summary>
    [CountryInfo(Code = "aw", PhoneCode = 297, Name  = "Aruba")]
    Aruba,
    /// <summary>
    /// The australia
    /// </summary>
    [CountryInfo(Code = "au", PhoneCode = 61, Name  = "Australia")]
    Australia,
    /// <summary>
    /// The austria
    /// </summary>
    [CountryInfo(Code = "at", PhoneCode = 43, Name  = "Austria")]
    Austria,
    /// <summary>
    /// The azerbaijan
    /// </summary>
    [CountryInfo(Code = "az", PhoneCode = 994, Name  = "Azerbaijan")]
    Azerbaijan,
    /// <summary>
    /// The bahrain
    /// </summary>
    [CountryInfo(Code = "bh", PhoneCode = 973, Name  = "Bahrain")]
    Bahrain,
    /// <summary>
    /// The bangladesh
    /// </summary>
    [CountryInfo(Code = "bd", PhoneCode = 880, Name  = "Bangladesh")]
    Bangladesh,
    /// <summary>
    /// The belarus
    /// </summary>
    [CountryInfo(Code = "by", PhoneCode = 375, Name  = "Belarus")]
    Belarus,
    /// <summary>
    /// The belgium
    /// </summary>
    [CountryInfo(Code = "be", PhoneCode = 32, Name  = "Belgium")]
    Belgium,
    /// <summary>
    /// The belize
    /// </summary>
    [CountryInfo(Code = "bz", PhoneCode = 501, Name  = "Belize")]
    Belize,
    /// <summary>
    /// The benin
    /// </summary>
    [CountryInfo(Code = "bj", PhoneCode = 229, Name  = "Benin")]
    Benin,
    /// <summary>
    /// The bhutan
    /// </summary>
    [CountryInfo(Code = "bt", PhoneCode = 975, Name  = "Bhutan")]
    Bhutan,
    /// <summary>
    /// The bolivia
    /// </summary>
    [CountryInfo(Code = "bo", PhoneCode = 591, Name  = "Plurinational State Of Bolivia")]
    Bolivia,
    /// <summary>
    /// The bosnia herzegovina
    /// </summary>
    [CountryInfo(Code = "ba", PhoneCode = 387, Name  = "Bosnia And Herzegovina")]
    BosniaHerzegovina,
    /// <summary>
    /// The botswana
    /// </summary>
    [CountryInfo(Code = "bw", PhoneCode = 267, Name  = "Botswana")]
    Botswana,
    /// <summary>
    /// The brazil
    /// </summary>
    [CountryInfo(Code = "br", PhoneCode = 55, Name  = "Brazil")]
    Brazil,
    /// <summary>
    /// The brunei darussalam
    /// </summary>
    [CountryInfo(Code = "bn", PhoneCode = 673, Name  = "Brunei Darussalam")]
    BruneiDarussalam,
    /// <summary>
    /// The bulgaria
    /// </summary>
    [CountryInfo(Code = "bg", PhoneCode = 359, Name  = "Bulgaria")]
    Bulgaria,
    /// <summary>
    /// The burkina faso
    /// </summary>
    [CountryInfo(Code = "bf", PhoneCode = 226, Name  = "Burkina Faso")]
    BurkinaFaso,
    /// <summary>
    /// The myanmar
    /// </summary>
    [CountryInfo(Code = "mm", PhoneCode = 95, Name  = "Myanmar")]
    Myanmar,
    /// <summary>
    /// The burundi
    /// </summary>
    [CountryInfo(Code = "bi", PhoneCode = 257, Name  = "Burundi")]
    Burundi,
    /// <summary>
    /// The cambodia
    /// </summary>
    [CountryInfo(Code = "kh", PhoneCode = 855, Name  = "Cambodia")]
    Cambodia,
    /// <summary>
    /// The cameroon
    /// </summary>
    [CountryInfo(Code = "cm", PhoneCode = 237, Name  = "Cameroon")]
    Cameroon,
    /// <summary>
    /// The canada
    /// </summary>
    [CountryInfo(Code = "ca", PhoneCode = 1, Name  = "Canada")]
    Canada,
    /// <summary>
    /// The cape verde
    /// </summary>
    [CountryInfo(Code = "cv", PhoneCode = 238, Name  = "Cape Verde")]
    CapeVerde,
    /// <summary>
    /// The central african republic
    /// </summary>
    [CountryInfo(Code = "cf", PhoneCode = 236, Name  = "Central African Republic")]
    CentralAfricanRepublic,
    /// <summary>
    /// The chad
    /// </summary>
    [CountryInfo(Code = "td", PhoneCode = 235, Name  = "Chad")]
    Chad,
    /// <summary>
    /// The chile
    /// </summary>
    [CountryInfo(Code = "cl", PhoneCode = 56, Name  = "Chile")]
    Chile,
    /// <summary>
    /// The china
    /// </summary>
    [CountryInfo(Code = "cn", PhoneCode = 86, Name  = "China")]
    China,
    /// <summary>
    /// The christmas island
    /// </summary>
    [CountryInfo(Code = "cx", PhoneCode = 61, Name  = "Christmas Island")]
    ChristmasIsland,
    /// <summary>
    /// The cocos islands
    /// </summary>
    [CountryInfo(Code = "cc", PhoneCode = 61, Name  = "Cocos (keeling) Islands")]
    CocosIslands,
    /// <summary>
    /// The colombia
    /// </summary>
    [CountryInfo(Code = "co", PhoneCode = 57, Name  = "Colombia")]
    Colombia,
    /// <summary>
    /// The comoros
    /// </summary>
    [CountryInfo(Code = "km", PhoneCode = 269, Name  = "Comoros")]
    Comoros,
    /// <summary>
    /// The congo
    /// </summary>
    [CountryInfo(Code = "cg", PhoneCode = 242, Name  = "Congo")]
    Congo,
    /// <summary>
    /// The democratic republic congo
    /// </summary>
    [CountryInfo(Code = "cd", PhoneCode = 243, Name  = "The Democratic Republic Of The Congo")]
    DemocraticRepublicCongo,
    /// <summary>
    /// The cook islands
    /// </summary>
    [CountryInfo(Code = "ck", PhoneCode = 682, Name  = "Cook Islands")]
    CookIslands,
    /// <summary>
    /// The costa rica
    /// </summary>
    [CountryInfo(Code = "cr", PhoneCode = 506, Name  = "Costa Rica")]
    CostaRica,
    /// <summary>
    /// The croatia
    /// </summary>
    [CountryInfo(Code = "hr", PhoneCode = 385, Name  = "Croatia")]
    Croatia,
    /// <summary>
    /// The cuba
    /// </summary>
    [CountryInfo(Code = "cu", PhoneCode = 53, Name  = "Cuba")]
    Cuba,
    /// <summary>
    /// The cyprus
    /// </summary>
    [CountryInfo(Code = "cy", PhoneCode = 357, Name  = "Cyprus")]
    Cyprus,
    /// <summary>
    /// The czech republic
    /// </summary>
    [CountryInfo(Code = "cz", PhoneCode = 420, Name  = "Czech Republic")]
    CzechRepublic,
    /// <summary>
    /// The denmark
    /// </summary>
    [CountryInfo(Code = "dk", PhoneCode = 45, Name  = "Denmark")]
    Denmark,
    /// <summary>
    /// The djibouti
    /// </summary>
    [CountryInfo(Code = "dj", PhoneCode = 253, Name  = "Djibouti")]
    Djibouti,
    /// <summary>
    /// The timorleste
    /// </summary>
    [CountryInfo(Code = "tl", PhoneCode = 670, Name  = "Timor-leste")]
    Timorleste,
    /// <summary>
    /// The ecuador
    /// </summary>
    [CountryInfo(Code = "ec", PhoneCode = 593, Name  = "Ecuador")]
    Ecuador,
    /// <summary>
    /// The egypt
    /// </summary>
    [CountryInfo(Code = "eg", PhoneCode = 20, Name  = "Egypt")]
    Egypt,
    /// <summary>
    /// The el salvador
    /// </summary>
    [CountryInfo(Code = "sv", PhoneCode = 503, Name  = "El Salvador")]
    ElSalvador,
    /// <summary>
    /// The equatorial guinea
    /// </summary>
    [CountryInfo(Code = "gq", PhoneCode = 240, Name  = "Equatorial Guinea")]
    EquatorialGuinea,
    /// <summary>
    /// The eritrea
    /// </summary>
    [CountryInfo(Code = "er", PhoneCode = 291, Name  = "Eritrea")]
    Eritrea,
    /// <summary>
    /// The estonia
    /// </summary>
    [CountryInfo(Code = "ee", PhoneCode = 372, Name  = "Estonia")]
    Estonia,
    /// <summary>
    /// The ethiopia
    /// </summary>
    [CountryInfo(Code = "et", PhoneCode = 251, Name  = "Ethiopia")]
    Ethiopia,
    /// <summary>
    /// The falkland islands4 fver british
    /// </summary>
    [CountryInfo(Code = "fk", PhoneCode = 500, Name  = "Falkland Islands")]
    FalklandIslands,
    /// <summary>
    /// The faroe islands
    /// </summary>
    [CountryInfo(Code = "fo", PhoneCode = 298, Name  = "Faroe Islands")]
    FaroeIslands,
    /// <summary>
    /// The fiji
    /// </summary>
    [CountryInfo(Code = "fj", PhoneCode = 679, Name  = "Fiji")]
    Fiji,
    /// <summary>
    /// The finland
    /// </summary>
    [CountryInfo(Code = "fi", PhoneCode = 358, Name  = "Finland")]
    Finland,
    /// <summary>
    /// The france
    /// </summary>
    [CountryInfo(Code = "fr", PhoneCode = 33, Name  = "France")]
    France,
    /// <summary>
    /// The french polynesia
    /// </summary>
    [CountryInfo(Code = "pf", PhoneCode = 689, Name  = "French Polynesia")]
    FrenchPolynesia,
    /// <summary>
    /// The gabon
    /// </summary>
    [CountryInfo(Code = "ga", PhoneCode = 241, Name  = "Gabon")]
    Gabon,
    /// <summary>
    /// The gambia
    /// </summary>
    [CountryInfo(Code = "gm", PhoneCode = 220, Name  = "Gambia")]
    Gambia,
    /// <summary>
    /// The georgia
    /// </summary>
    [CountryInfo(Code = "ge", PhoneCode = 995, Name  = "Georgia")]
    Georgia,
    /// <summary>
    /// The germany
    /// </summary>
    [CountryInfo(Code = "de", PhoneCode = 49, Name  = "Germany")]
    Germany,
    /// <summary>
    /// The ghana
    /// </summary>
    [CountryInfo(Code = "gh", PhoneCode = 233, Name  = "Ghana")]
    Ghana,
    /// <summary>
    /// The gibraltar
    /// </summary>
    [CountryInfo(Code = "gi", PhoneCode = 350, Name  = "Gibraltar")]
    Gibraltar,
    /// <summary>
    /// The greece
    /// </summary>
    [CountryInfo(Code = "gr", PhoneCode = 30, Name  = "Greece")]
    Greece,
    /// <summary>
    /// The greenland
    /// </summary>
    [CountryInfo(Code = "gl", PhoneCode = 299, Name  = "Greenland")]
    Greenland,
    /// <summary>
    /// The guatemala
    /// </summary>
    [CountryInfo(Code = "gt", PhoneCode = 502, Name  = "Guatemala")]
    Guatemala,
    /// <summary>
    /// The guinea
    /// </summary>
    [CountryInfo(Code = "gn", PhoneCode = 224, Name  = "Guinea")]
    Guinea,
    /// <summary>
    /// The guineabissau
    /// </summary>
    [CountryInfo(Code = "gw", PhoneCode = 245, Name  = "Guinea-bissau")]
    Guineabissau,
    /// <summary>
    /// The guyana
    /// </summary>
    [CountryInfo(Code = "gy", PhoneCode = 592, Name  = "Guyana")]
    Guyana,
    /// <summary>
    /// The haiti
    /// </summary>
    [CountryInfo(Code = "ht", PhoneCode = 509, Name  = "Haiti")]
    Haiti,
    /// <summary>
    /// The honduras
    /// </summary>
    [CountryInfo(Code = "hn", PhoneCode = 504, Name  = "Honduras")]
    Honduras,
    /// <summary>
    /// The hong kong
    /// </summary>
    [CountryInfo(Code = "hk", PhoneCode = 852, Name  = "Hong Kong")]
    HongKong,
    /// <summary>
    /// The hungary
    /// </summary>
    [CountryInfo(Code = "hu", PhoneCode = 36, Name  = "Hungary")]
    Hungary,
    /// <summary>
    /// The india
    /// </summary>
    [CountryInfo(Code = "in", PhoneCode = 91, Name  = "India")]
    India,
    /// <summary>
    /// The indonesia
    /// </summary>
    [CountryInfo(Code = "id", PhoneCode = 62, Name  = "Indonesia")]
    Indonesia,
    /// <summary>
    /// The iran
    /// </summary>
    [CountryInfo(Code = "ir", PhoneCode = 98, Name  = "Islamic Republic Of Iran")]
    Iran,
    /// <summary>
    /// The iraq
    /// </summary>
    [CountryInfo(Code = "iq", PhoneCode = 964, Name  = "Iraq")]
    Iraq,
    /// <summary>
    /// The ireland
    /// </summary>
    [CountryInfo(Code = "ie", PhoneCode = 353, Name  = "Ireland")]
    Ireland,
    /// <summary>
    /// The isle of man
    /// </summary>
    [CountryInfo(Code = "im", PhoneCode = 44, Name  = "Isle Of Man")]
    IsleOfMan,
    /// <summary>
    /// The israel
    /// </summary>
    [CountryInfo(Code = "il", PhoneCode = 972, Name  = "Israel")]
    Israe,
    /// <summary>
    /// The italy
    /// </summary>
    [CountryInfo(Code = "it", PhoneCode = 39, Name  = "Italy")]
    Italy,
    /// <summary>
    /// The cote divoire
    /// </summary>
    [CountryInfo(Code = "ci", PhoneCode = 225, Name  = "Côte D'ivoire")]
    CoteDivoire,
    /// <summary>
    /// The japan
    /// </summary>
    [CountryInfo(Code = "jp", PhoneCode = 81, Name  = "Japan")]
    Japan,
    /// <summary>
    /// The jordan
    /// </summary>
    [CountryInfo(Code = "jo", PhoneCode = 962, Name  = "Jordan")]
    Jordan,
    /// <summary>
    /// The kazakhstan
    /// </summary>
    [CountryInfo(Code = "kz", PhoneCode = 7, Name  = "Kazakhstan")]
    Kazakhstan,
    /// <summary>
    /// The kenya
    /// </summary>
    [CountryInfo(Code = "ke", PhoneCode = 254, Name  = "Kenya")]
    Kenya,
    /// <summary>
    /// The kiribati
    /// </summary>
    [CountryInfo(Code = "ki", PhoneCode = 686, Name  = "Kiribati")]
    Kiribati,
    /// <summary>
    /// The kuwait
    /// </summary>
    [CountryInfo(Code = "kw", PhoneCode = 965, Name  = "Kuwait")]
    Kuwait,
    /// <summary>
    /// The kyrgyzstan
    /// </summary>
    [CountryInfo(Code = "kg", PhoneCode = 996, Name  = "Kyrgyzstan")]
    Kyrgyzstan,
    /// <summary>
    /// The lao peoples dr
    /// </summary>
    [CountryInfo(Code = "la", PhoneCode = 856, Name  = "Lao People's Democratic Republic")]
    LaoPeoplesDR,
    /// <summary>
    /// The latvia
    /// </summary>
    [CountryInfo(Code = "lv", PhoneCode = 371, Name  = "Latvia")]
    Latvia,
    /// <summary>
    /// The lebanon
    /// </summary>
    [CountryInfo(Code = "lb", PhoneCode = 961, Name  = "Lebanon")]
    Lebanon,
    /// <summary>
    /// The lesotho
    /// </summary>
    [CountryInfo(Code = "ls", PhoneCode = 266, Name  = "Lesotho")]
    Lesotho,
    /// <summary>
    /// The liberia
    /// </summary>
    [CountryInfo(Code = "lr", PhoneCode = 231, Name  = "Liberia")]
    Liberia,
    /// <summary>
    /// The libya
    /// </summary>
    [CountryInfo(Code = "ly", PhoneCode = 218, Name  = "Libya")]
    Libya,
    /// <summary>
    /// The liechtenstein
    /// </summary>
    [CountryInfo(Code = "li", PhoneCode = 423, Name  = "Liechtenstein")]
    Liechtenstein,
    /// <summary>
    /// The lithuania
    /// </summary>
    [CountryInfo(Code = "lt", PhoneCode = 370, Name  = "Lithuania")]
    Lithuania,
    /// <summary>
    /// The luxembourg
    /// </summary>
    [CountryInfo(Code = "lu", PhoneCode = 352, Name  = "Luxembourg")]
    Luxembourg,
    /// <summary>
    /// The macao
    /// </summary>
    [CountryInfo(Code = "mo", PhoneCode = 853, Name  = "Macao")]
    Macao,
    /// <summary>
    /// The macedonia
    /// </summary>
    [CountryInfo(Code = "mk", PhoneCode = 389, Name  = "Macedonia")]
    Macedonia,
    /// <summary>
    /// The madagascar
    /// </summary>
    [CountryInfo(Code = "mg", PhoneCode = 261, Name  = "Madagascar")]
    Madagascar,
    /// <summary>
    /// The malawi
    /// </summary>
    [CountryInfo(Code = "mw", PhoneCode = 265, Name  = "Malawi")]
    Malawi,
    /// <summary>
    /// The malaysia
    /// </summary>
    [CountryInfo(Code = "my", PhoneCode = 60, Name  = "Malaysia")]
    Malaysia,
    /// <summary>
    /// The maldives
    /// </summary>
    [CountryInfo(Code = "mv", PhoneCode = 960, Name  = "Maldives")]
    Maldives,
    /// <summary>
    /// The mali
    /// </summary>
    [CountryInfo(Code = "ml", PhoneCode = 223, Name  = "Mali")]
    Mali,
    /// <summary>
    /// The malta
    /// </summary>
    [CountryInfo(Code = "mt", PhoneCode = 356, Name  = "Malta")]
    Malta,
    /// <summary>
    /// The marshall islands
    /// </summary>
    [CountryInfo(Code = "mh", PhoneCode = 692, Name  = "Marshall Islands")]
    MarshallIslands,
    /// <summary>
    /// The mauritania
    /// </summary>
    [CountryInfo(Code = "mr", PhoneCode = 222, Name  = "Mauritania")]
    Mauritania,
    /// <summary>
    /// The mauritius
    /// </summary>
    [CountryInfo(Code = "mu", PhoneCode = 230, Name  = "Mauritius")]
    Mauritius,
    /// <summary>
    /// The mayotte
    /// </summary>
    [CountryInfo(Code = "yt", PhoneCode = 262, Name  = "Mayotte")]
    Mayotte,
    /// <summary>
    /// The mexico
    /// </summary>
    [CountryInfo(Code = "mx", PhoneCode = 52, Name  = "Mexico")]
    Mexico,
    /// <summary>
    /// The micronesia
    /// </summary>
    [CountryInfo(Code = "fm", PhoneCode = 691, Name  = "Federated States Of Micronesia")]
    Micronesia,
    /// <summary>
    /// The moldova
    /// </summary>
    [CountryInfo(Code = "md", PhoneCode = 373, Name  = "Republic Of Moldova")]
    Moldova,
    /// <summary>
    /// The monaco
    /// </summary>
    [CountryInfo(Code = "mc", PhoneCode = 377, Name  = "Monaco")]
    Monaco,
    /// <summary>
    /// The mongolia
    /// </summary>
    [CountryInfo(Code = "mn", PhoneCode = 976, Name  = "Mongolia")]
    Mongolia,
    /// <summary>
    /// The montenegro
    /// </summary>
    [CountryInfo(Code = "me", PhoneCode = 382, Name  = "Montenegro")]
    Montenegro,
    /// <summary>
    /// The morocco
    /// </summary>
    [CountryInfo(Code = "ma", PhoneCode = 212, Name  = "Morocco")]
    Morocco,
    /// <summary>
    /// The mozambique
    /// </summary>
    [CountryInfo(Code = "mz", PhoneCode = 258, Name  = "Mozambique")]
    Mozambique,
    /// <summary>
    /// The namibia
    /// </summary>
    [CountryInfo(Code = "na", PhoneCode = 264, Name  = "Namibia")]
    Namibia,
    /// <summary>
    /// The nauru
    /// </summary>
    [CountryInfo(Code = "nr", PhoneCode = 674, Name  = "Nauru")]
    Nauru,
    /// <summary>
    /// The nepal
    /// </summary>
    [CountryInfo(Code = "np", PhoneCode = 977, Name  = "Nepal")]
    Nepal,
    /// <summary>
    /// The netherlands
    /// </summary>
    [CountryInfo(Code = "nl", PhoneCode = 31, Name  = "Netherlands")]
    Netherlands,
    /// <summary>
    /// Creates new caledonia.
    /// </summary>
    [CountryInfo(Code = "nc", PhoneCode = 687, Name  = "New Caledonia")]
    NewCaledonia,
    /// <summary>
    /// Creates new zealand.
    /// </summary>
    [CountryInfo(Code = "nz", PhoneCode = 64, Name  = "New Zealand")]
    NewZealand,
    /// <summary>
    /// The nicaragua
    /// </summary>
    [CountryInfo(Code = "ni", PhoneCode = 505, Name  = "Nicaragua")]
    Nicaragua,
    /// <summary>
    /// The niger
    /// </summary>
    [CountryInfo(Code = "ne", PhoneCode = 227, Name  = "Niger")]
    Niger,
    /// <summary>
    /// The nigeria
    /// </summary>
    [CountryInfo(Code = "ng", PhoneCode = 234, Name  = "Nigeria")]
    Nigeria,
    /// <summary>
    /// The niue
    /// </summary>
    [CountryInfo(Code = "nu", PhoneCode = 683, Name  = "Niue")]
    Niue,
    /// <summary>
    /// The north korea
    /// </summary>
    [CountryInfo(Code = "kp", PhoneCode = 850, Name  = "Democratic People's Republic Of Korea")]
    NorthKorea,
    /// <summary>
    /// The norway
    /// </summary>
    [CountryInfo(Code = "no", PhoneCode = 47, Name  = "Norway")]
    Norway,
    /// <summary>
    /// The oman
    /// </summary>
    [CountryInfo(Code = "om", PhoneCode = 968, Name  = "Oman")]
    Oman,
    /// <summary>
    /// The pakistan
    /// </summary>
    [CountryInfo(Code = "pk", PhoneCode = 92, Name  = "Pakistan")]
    Pakistan,
    /// <summary>
    /// The palau
    /// </summary>
    [CountryInfo(Code = "pw", PhoneCode = 680, Name  = "Palau")]
    Palau,
    /// <summary>
    /// The panama
    /// </summary>
    [CountryInfo(Code = "pa", PhoneCode = 507, Name  = "Panama")]
    Panama,
    /// <summary>
    /// The papua new guinea
    /// </summary>
    [CountryInfo(Code = "pg", PhoneCode = 675, Name  = "Papua New Guinea")]
    PapuaNewGuinea,
    /// <summary>
    /// The paraguay
    /// </summary>
    [CountryInfo(Code = "py", PhoneCode = 595, Name  = "Paraguay")]
    Paraguay,
    /// <summary>
    /// The peru
    /// </summary>
    [CountryInfo(Code = "pe", PhoneCode = 51, Name  = "Peru")]
    Peru,
    /// <summary>
    /// The philippines
    /// </summary>
    [CountryInfo(Code = "ph", PhoneCode = 63, Name  = "Philippines")]
    Philippines,
    /// <summary>
    /// The pitcairn
    /// </summary>
    [CountryInfo(Code = "pn", PhoneCode = 870, Name  = "Pitcairn")]
    Pitcairn,
    /// <summary>
    /// The poland
    /// </summary>
    [CountryInfo(Code = "pl", PhoneCode = 48, Name  = "Poland")]
    Poland,
    /// <summary>
    /// The portugal
    /// </summary>
    [CountryInfo(Code = "pt", PhoneCode = 351, Name  = "Portugal")]
    Portugal,
    /// <summary>
    /// The puerto rico
    /// </summary>
    [CountryInfo(Code = "pr", PhoneCode = 1, Name  = "Puerto Rico")]
    PuertoRico,
    /// <summary>
    /// The qatar
    /// </summary>
    [CountryInfo(Code = "qa", PhoneCode = 974, Name  = "Qatar")]
    Qatar,
    /// <summary>
    /// The romania
    /// </summary>
    [CountryInfo(Code = "ro", PhoneCode = 40, Name  = "Romania")]
    Romania,
    /// <summary>
    /// The russian federation
    /// </summary>
    [CountryInfo(Code = "ru", PhoneCode = 7, Name  = "Russian Federation")]
    RussianFederation,
    /// <summary>
    /// The rwanda
    /// </summary>
    [CountryInfo(Code = "rw", PhoneCode = 250, Name  = "Rwanda")]
    Rwanda,
    /// <summary>
    /// The saint barthélemy
    /// </summary>
    [CountryInfo(Code = "bl", PhoneCode = 590, Name  = "Saint Barthélemy")]
    SaintBarthélemy,
    /// <summary>
    /// The samoa
    /// </summary>
    [CountryInfo(Code = "ws", PhoneCode = 685, Name  = "Samoa")]
    Samoa,
    /// <summary>
    /// The san marino
    /// </summary>
    [CountryInfo(Code = "sm", PhoneCode = 378, Name  = "San Marino")]
    SanMarino,
    /// <summary>
    /// The sao tome and principe
    /// </summary>
    [CountryInfo(Code = "st", PhoneCode = 239, Name  = "Sao Tome And Principe")]
    SaoTomeAndPrincipe,
    /// <summary>
    /// The saudi arabia
    /// </summary>
    [CountryInfo(Code = "sa", PhoneCode = 966, Name  = "Saudi Arabia")]
    SaudiArabia,
    /// <summary>
    /// The senegal
    /// </summary>
    [CountryInfo(Code = "sn", PhoneCode = 221, Name  = "Senegal")]
    Senegal,
    /// <summary>
    /// The serbia
    /// </summary>
    [CountryInfo(Code = "rs", PhoneCode = 381, Name  = "Serbia")]
    Serbia,
    /// <summary>
    /// The seychelles
    /// </summary>
    [CountryInfo(Code = "sc", PhoneCode = 248, Name  = "Seychelles")]
    Seychelles,
    /// <summary>
    /// The sierra leone
    /// </summary>
    [CountryInfo(Code = "sl", PhoneCode = 232, Name  = "Sierra Leone")]
    SierraLeone,
    /// <summary>
    /// The singapore
    /// </summary>
    [CountryInfo(Code = "sg", PhoneCode = 65, Name  = "Singapore")]
    Singapore,
    /// <summary>
    /// The slovakia
    /// </summary>
    [CountryInfo(Code = "sk", PhoneCode = 421, Name  = "Slovakia")]
    Slovakia,
    /// <summary>
    /// The slovenia
    /// </summary>
    [CountryInfo(Code = "si", PhoneCode = 386, Name  = "Slovenia")]
    Slovenia,
    /// <summary>
    /// The solomon islands
    /// </summary>
    [CountryInfo(Code = "sb", PhoneCode = 677, Name  = "Solomon Islands")]
    SolomonIslands,
    /// <summary>
    /// The somalia
    /// </summary>
    [CountryInfo(Code = "so", PhoneCode = 252, Name  = "Somalia")]
    Somalia,
    /// <summary>
    /// The south africa
    /// </summary>
    [CountryInfo(Code = "za", PhoneCode = 27, Name  = "South Africa")]
    SouthAfrica,
    /// <summary>
    /// The south korea
    /// </summary>
    [CountryInfo(Code = "kr", PhoneCode = 82, Name  = "Republic Of Korea")]
    SouthKorea,
    /// <summary>
    /// The spain
    /// </summary>
    [CountryInfo(Code = "es", PhoneCode = 34, Name  = "Spain")]
    Spain,
    /// <summary>
    /// The sri lanka
    /// </summary>
    [CountryInfo(Code = "lk", PhoneCode = 94, Name  = "Sri Lanka")]
    SriLanka,
    /// <summary>
    /// The saint helena
    /// </summary>
    [CountryInfo(Code = "sh", PhoneCode = 290, Name  = "Saint Helena, Ascension And Tristan Da Cunha")]
    SaintHelena,
    /// <summary>
    /// The saint pierre miquelon
    /// </summary>
    [CountryInfo(Code = "pm", PhoneCode = 508, Name  = "Saint Pierre And Miquelon")]
    SaintPierreMiquelon,
    /// <summary>
    /// The sudan
    /// </summary>
    [CountryInfo(Code = "sd", PhoneCode = 249, Name  = "Sudan")]
    Sudan,
    /// <summary>
    /// The suriname
    /// </summary>
    [CountryInfo(Code = "sr", PhoneCode = 597, Name  = "Suriname")]
    Suriname,
    /// <summary>
    /// The swaziland
    /// </summary>
    [CountryInfo(Code = "sz", PhoneCode = 268, Name  = "Swaziland")]
    Swaziland,
    /// <summary>
    /// The sweden
    /// </summary>
    [CountryInfo(Code = "se", PhoneCode = 46, Name  = "Sweden")]
    Sweden,
    /// <summary>
    /// The switzerland
    /// </summary>
    [CountryInfo(Code = "ch", PhoneCode = 41, Name  = "Switzerland")]
    Switzerland,
    /// <summary>
    /// The syrian arab republic
    /// </summary>
    [CountryInfo(Code = "sy", PhoneCode = 963, Name  = "Syrian Arab Republic")]
    SyrianArabRepublic,
    /// <summary>
    /// The taiwan
    /// </summary>
    [CountryInfo(Code = "tw", PhoneCode = 886, Name  = "Taiwan, Province Of China")]
    Taiwan,
    /// <summary>
    /// The tajikistan
    /// </summary>
    [CountryInfo(Code = "tj", PhoneCode = 992, Name  = "Tajikistan")]
    Tajikistan,
    /// <summary>
    /// The tanzania
    /// </summary>
    [CountryInfo(Code = "tz", PhoneCode = 255, Name  = "United Republic Of Tanzania")]
    Tanzania,
    /// <summary>
    /// The thailand
    /// </summary>
    [CountryInfo(Code = "th", PhoneCode = 66, Name  = "Thailand")]
    Thailand,
    /// <summary>
    /// The togo
    /// </summary>
    [CountryInfo(Code = "tg", PhoneCode = 228, Name  = "Togo")]
    Togo,
    /// <summary>
    /// The tokelau
    /// </summary>
    [CountryInfo(Code = "tk", PhoneCode = 690, Name  = "Tokelau")]
    Tokelau,
    /// <summary>
    /// The tonga
    /// </summary>
    [CountryInfo(Code = "to", PhoneCode = 676, Name  = "Tonga")]
    Tonga,
    /// <summary>
    /// The tunisia
    /// </summary>
    [CountryInfo(Code = "tn", PhoneCode = 216, Name  = "Tunisia")]
    Tunisia,
    /// <summary>
    /// The turkey
    /// </summary>
    [CountryInfo(Code = "tr", PhoneCode = 90, Name  = "Turkey")]
    Turkey,
    /// <summary>
    /// The turkmenistan87
    /// </summary>
    [CountryInfo(Code = "tm", PhoneCode = 993, Name  = "Turkmenistan")]
    Turkmenistan87,
    /// <summary>
    /// The tuvalu
    /// </summary>
    [CountryInfo(Code = "tv", PhoneCode = 688, Name  = "Tuvalu")]
    Tuvalu,
    /// <summary>
    /// The united arab emirates
    /// </summary>
    [CountryInfo(Code = "ae", PhoneCode = 971, Name  = "United Arab Emirates")]
    UnitedArabEmirates,
    /// <summary>
    /// The uganda
    /// </summary>
    [CountryInfo(Code = "ug", PhoneCode = 256, Name  = "Uganda")]
    Uganda,
    /// <summary>
    /// The united kingdom
    /// </summary>
    [CountryInfo(Code = "gb", PhoneCode = 44, Name  = "United Kingdom")]
    UnitedKingdom,
    /// <summary>
    /// The ukraine
    /// </summary>
    [CountryInfo(Code = "ua", PhoneCode = 380, Name  = "Ukraine")]
    Ukraine,
    /// <summary>
    /// The uruguay
    /// </summary>
    [CountryInfo(Code = "uy", PhoneCode = 598, Name  = "Uruguay")]
    Uruguay,
    /// <summary>
    /// The united states
    /// </summary>
    [CountryInfo(Code = "us", PhoneCode = 1, Name  = "United States")]
    UnitedStates,
    /// <summary>
    /// The uzbekistan
    /// </summary>
    [CountryInfo(Code = "uz", PhoneCode = 998, Name  = "Uzbekistan")]
    Uzbekistan,
    /// <summary>
    /// The vanuatu
    /// </summary>
    [CountryInfo(Code = "vu", PhoneCode = 678, Name  = "Vanuatu")]
    Vanuatu,
    /// <summary>
    /// The vatican city
    /// </summary>
    [CountryInfo(Code = "va", PhoneCode = 39, Name  = "Vatican City")]
    vaticanCity,
    /// <summary>
    /// The holy see
    /// </summary>
    [CountryInfo(Code = "va", PhoneCode = 39, Name  = "Holy See")]
    HolySee,
    /// <summary>
    /// The venezuela
    /// </summary>
    [CountryInfo(Code = "ve", PhoneCode = 58, Name  = "Bolivarian Republic Of Venezuela")]
    Venezuela,
    /// <summary>
    /// The viet nam
    /// </summary>
    [CountryInfo(Code = "vn", PhoneCode = 84, Name  = "Viet Nam")]
    VietNam,
    /// <summary>
    /// The wallis futuna
    /// </summary>
    [CountryInfo(Code = "wf", PhoneCode = 681, Name  = "Wallis And Futuna")]
    WallisFutuna,
    /// <summary>
    /// The yemen
    /// </summary>
    [CountryInfo(Code = "ye", PhoneCode = 967, Name  = "Yemen")]
    Yemen,
    /// <summary>
    /// The zambia
    /// </summary>
    [CountryInfo(Code = "zm", PhoneCode = 260, Name  = "Zambia")]
    Zambia,
    /// <summary>
    /// The zimbabwe
    /// </summary>
    [CountryInfo(Code = "zw", PhoneCode = 263, Name  = "Zimbabwe")]
    Zimbabwe
}