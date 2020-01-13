﻿using System;
using Core.ExperimentalCompression;

namespace ConsoleApp.Years.Year2016
{
    public class Day09 : Day
    {
        public Day09() : base(9)
        {
        }

        protected override void RunDay()
        {
            WritePartTitle();
            var decompressor = new FileDecompressor(Input);
            Console.WriteLine($"Decompressed length: {decompressor.Decompressed.Length}");
        }

        private const string Input = "(143x8)(22x7)(4x15)XOPG(7x9)JDPAKGM(8x8)ALGCJRZQ(38x1)(4x10)VNSW(12x10)BZPAZABYKIDJ(3x14)IHF(40x15)(34x8)UGTIHCTVONZPPIWUAEGHGFJUNTIMIELOLW(6x1)XLMMKD(19x1)CLTHZNGCSMZITKBOZBZ(16x10)VALWVLALGUCXHAJT(121x14)(33x14)PXYJATIWOWRSCORYAPBWJSFOOXURQGUPE(56x5)(10x3)DQINJUWAMT(16x5)FSEYWRHWTGLEANIZ(12x4)ISBCDNXTOTIC(1x15)B(6x10)(1x7)CSBHNVBBNQPUFVSPODCHALPI(6851x14)(1837x7)(353x11)(7x4)(2x4)YQ(7x15)MOBFPOM(320x14)(272x2)(9x10)YBHVXLRDX(5x10)XJRJL(65x8)(1x1)T(21x2)XMPKSAQBHNXFSIGDQKXBT(2x7)HP(19x3)OVTOKRSBKJAVBIOUEOL(89x11)(8x5)WDUCSQFE(5x3)TUGKX(16x11)XTJETBLUHHKPKKAJ(7x13)RZAQFQM(24x7)DAVMEYZXPMQWKRKQDRDMYWZK(73x9)(5x1)CMJQZ(6x7)ZGGEFE(1x13)M(11x4)MOVLJYGTUUO(22x4)QZLZYJTLBGKNWCBQEVPPVE(35x9)(21x8)ZJZWFKGZJVRBTMGUUVLMD(2x14)HH(223x4)(63x8)(18x10)LOCHLWKDEDHYHDOVDB(32x9)DRUTZMMGSMRGGMTKBCKYLKCRHENSVICE(3x12)VQE(30x10)FVBATVKKQMVCURXCYZPZNVVRMCIKLU(100x12)(30x6)(23x15)(17x1)XVZNYVGWAZTXMPFQK(2x5)OD(12x14)DIBMBTMLPJKQ(32x6)(12x3)QHTMLKVXWQZK(8x14)GJCLEEAU(389x1)(226x8)(3x8)FBD(25x3)(18x14)KMVYMVSRAXIWSCECNW(170x8)(49x5)(9x4)ULEYLYNJY(18x7)CLTXDTVORLXUOTFCLJ(5x11)PTURS(53x12)(5x8)OBOYG(15x8)SKAEMEEBXJUJUWW(16x2)MCFKLYSMPEAEQFBA(32x6)(7x3)RHAXCPE(8x15)LAMFEDAW(1x9)I(11x5)FSPLMOCWRZK(4x14)WGCQ(149x1)(84x10)(38x13)(18x10)JVWJTCUNDKLYLIFNAK(1x13)O(1x9)G(13x10)(7x14)PGQAEDM(13x6)SLWXIJOMADJLP(3x10)VPI(43x3)(36x11)(1x14)T(4x10)SKRX(5x2)OMCYG(4x6)DQRQ(835x11)(174x10)(81x12)(67x9)(2x13)NR(18x12)RAJKIINYGUXLOUYENK(13x13)OZIWQKWWTUJXF(8x11)EMKSLPRX(3x1)AGE(80x4)(68x4)(2x1)UX(22x12)SMBEEPGHUNJAQZKAWVLLMT(8x4)PFJOHXRV(1x6)X(8x6)SEIMXVVM(1x1)J(69x2)(8x4)FURIFHFB(40x13)(21x5)(5x4)LNZZY(6x2)QFGLMR(7x12)(2x8)XS(3x13)OWJ(571x6)(174x6)(14x2)BSADXDDLJLEVBB(54x8)(5x13)XDYHG(8x2)RZNUYFXX(1x7)G(10x8)ZZWDGZTDKN(3x4)OFG(87x11)(27x6)IKAHWVVLATFUIMJOTCZMIOPAFCI(6x4)WXDRJN(16x3)VHKSZEABZLZJSCEP(14x13)NFTURHBVVUHXTP(96x15)(56x15)(2x6)SG(3x15)MJH(33x12)RIWEVKXHXGWSJOMLFQPNJILPTNYOCKPOK(11x7)(5x11)JBZRA(2x5)UC(3x10)OMB(6x13)UYKLMI(75x8)(5x7)RNUEO(59x4)(16x8)ISRGFLEIVCWUHMXM(2x10)XJ(1x2)F(16x12)XVTXZKCKMPXCRZKE(186x10)(13x15)OOKJFSXSSGOKX(56x6)(16x15)GOGUQYXMCUOYIZAS(13x3)XDXFDHEEKCXSD(9x8)LNBOQQDVV(55x11)(2x15)OR(1x15)F(13x10)IDEHWRDIWEKSW(14x9)KYLMLJMZIEPMEZ(3x3)ETX(28x1)(3x4)JFL(14x8)MWDXXMSIFHRGOT(2x2)ZF(2764x12)(429x11)(149x7)(7x7)UVPIIIH(33x10)CMDUQOXWGOIYJPXMDJSVBSBTKZCNWSZEP(90x13)(84x1)(6x4)ZVCUNP(2x6)SF(23x2)VTWDHVYQEWTIHUWIKIUOKKR(9x13)CTXDYHPTH(15x15)NAHZFZHMSJCPDZD(266x3)(11x15)SADHZVETNOX(241x6)(14x5)YUVPESDLQTIKTV(46x1)ZIMMCIPFXSZJNSQUPRPFNAOCIFINUDOCSGYYYTWOPFKBGK(66x13)(28x3)CMZWUBZEIKULJWDWVPYFTZKTRXBG(5x8)HYKCE(4x14)KQQH(7x5)PMPUJYI(74x1)(12x13)ABUKTEQSSDJY(1x15)R(9x9)OVZPKGCLK(2x11)TG(19x13)TAJXSLMQKEAXQRXEPRP(10x4)VMOGPHQCOE(498x10)(21x5)(5x3)PUUYR(5x10)RNLRC(19x2)WSXCBBUHPRTTDLVVCTW(225x8)(7x3)AZCJJGH(194x12)(21x12)PGXOCMGUAPORUREJXOZVV(1x10)E(12x11)MYUUCXKMOGOW(59x8)(24x6)OVCPKGYHILZMSRUKLSNEXYWS(6x10)YXSZQF(10x11)RJCURKGVSA(69x2)(8x6)MUBPJIEW(2x1)YV(13x4)EYQREONZMEQGI(14x7)KRAJKLWPQUOHAF(5x1)IINXC(6x5)QCFNCP(207x5)(162x8)(21x1)(6x6)URWVXQ(5x7)NTTNO(51x10)(3x9)KTX(15x10)KIDPFFJOMAKFGEP(8x3)EDQKQGDQ(2x11)XP(9x9)YPVKLXABX(28x4)(10x8)ZPOJTXYCWK(1x6)H(1x9)V(22x13)(1x11)D(2x14)IB(1x14)R(8x1)IMNVABZA(18x10)AYYHMMTVCTALMDRTTY(1186x4)(426x12)(10x12)(5x7)COTFY(185x11)(26x3)(3x9)MBB(7x7)LBMDHKJ(1x9)L(23x13)QGMBUZUVDVCVLEYADPLMWVQ(3x11)XAP(83x5)(25x12)EKVTQEDEQXIFIGMJNUKZJTQYT(36x4)DEQXETWJMAUEOWHEZNHWGDEWJERBWZMLIBDR(3x15)UDI(19x8)JKCQYDKDITVWBXULCAK(208x11)(84x3)(1x5)N(18x15)TSKZQXYIUVKGKMKLGT(13x6)UEONLUHISGWPT(28x2)MTYEJXWLSDNOVKAAEDDTGLLTGBHR(76x11)(19x8)HNKLLAKBLOSVSDMFOLE(9x3)ERDRBAHWP(8x11)KCOHRRBA(7x5)GCVHIKI(6x9)OVOUKW(11x11)ZLMSNQQTTLW(11x1)(6x9)QBZQNW(376x8)(256x14)(24x6)(6x8)XXKOAV(8x4)YERUBDOP(21x2)VSYQGMMOAQNFSZNKEJMXL(97x12)(20x4)ELTZIBCGEFVJHPETQZHO(3x8)FQG(1x15)Z(37x9)CDWVBANWVKKNVSJMMJPGONUFLDKHUDVIOBXUF(7x14)HOKGPLC(39x10)(19x13)AUHRABETDCLCQIDLQTO(8x7)IHLJMIAM(43x1)(22x3)WHQKLPTHFSHNGCEYYFVAJZ(9x14)IQGSXZIFB(6x9)PQZUZM(81x12)(12x7)RVDAWIZOLVQX(46x1)(5x5)ZZUAP(9x7)TUBIKHAVF(1x4)C(3x5)ZDW(3x2)GZR(5x13)ZTKCX(8x5)RUIPWQKS(139x12)(4x9)ZQRF(52x15)(37x1)(12x14)BWDQNPBEHHUW(4x11)OCUO(2x11)SP(4x2)OFAA(65x1)(18x10)(12x2)CFRFJOBRRAHZ(34x7)(1x1)G(14x4)VOAXQXVGUMVINO(2x15)SW(191x11)(183x14)(100x14)(1x9)U(12x15)VTUYYRSODESQ(31x15)TGSDRMNTWWYHZDTMTZKWIPJMEXCIKMY(18x5)HYFYNJYBHAIDDHFNNL(8x5)YBYZYEJR(8x2)RTBHYMQI(42x12)(10x10)IYEPKYGTOB(3x15)KAM(1x9)F(5x4)LEWBO(8x4)FMFOTKAU(17x8)KNDZJJLCNMGUTBYNS(467x13)(209x6)(148x14)(3x5)XSE(6x1)XJNQKW(74x11)(30x2)OYEEFTIUNLLCTKZHSMUOEBGAJUKLHR(20x2)NVGBWMJWWDPSOHSDVLJD(7x7)QJRZAUF(42x8)YKPGEOXLZMJOLRJTUNOXAYDJKMTXQGDNRVINDLBPTD(12x1)SHAGOOFKKBXE(29x4)(16x13)(1x2)C(5x3)QJMEV(1x5)H(244x4)(110x10)(103x5)(4x12)ZVJM(28x10)JLHDJYLAPCPDLHOZURARRTJTOYXI(13x3)LWRNIXINNQMSJ(20x2)YCYAHDNQLLBKZKVUNRUJ(8x7)WHXSOQVK(71x10)(14x12)(9x3)SUTUFTGLH(1x5)X(37x13)ZDZQBIKRACVXLTTBPIWLVVOXTQUMWMBGHRPLM(41x11)(15x10)(9x13)IKUYTOKNU(12x10)YBTNEIPFBPYQ(144x13)(118x13)(94x8)(3x14)HBL(51x10)(16x14)GJIIPYAQSJSZOAYG(22x2)LSCXUGELCOUDODAXICVDKM(4x15)ZJOT(10x12)MDMYANLMSJ(12x2)SFNEHAVVNRVA(12x1)KORQJVTAAYCM(2204x11)(341x8)(334x5)(125x3)(51x6)(7x11)JSIXUKZ(5x3)ZRFCB(7x6)BCAGHEM(10x1)XAKGJBAFVH(62x5)(23x15)EJCYSGOHVWYIXJVZAGONCUU(5x4)PFOZW(16x1)ZRQQLBUIILWQVERI(113x15)(2x8)PZ(99x12)(14x5)WIHCMMGPTYRSYU(14x7)UQWHOZRLTGQBAD(4x15)TMGY(27x11)NQOSQKJNZETHKKBEQQFRAZXANUJ(9x15)EJQYPZTSF(75x4)(3x12)JEV(22x8)MKXYJKAGYTGCIUZMFMYFXG(31x15)(13x15)AICLOBFSVABCW(6x5)RMVEDR(570x12)(191x8)(21x8)(15x8)(2x14)RA(2x2)RP(18x3)DLYMJPSBGPDEJPSWTD(132x12)(27x11)MALDYBRFSBALZSSKXGDEJHRMPEY(6x15)HDGAOT(80x8)(21x15)RPMHZBMKVBKVYFAKGBUOG(11x7)JDMRMBXYXFJ(3x3)PGK(9x15)XHGWFEKMS(6x12)OBDMXN(10x13)VZTXDPKEOJ(221x14)(136x5)(7x7)KOFBQMH(17x8)AXGVRRRVIYUTVLXYK(6x7)OCQVND(43x7)FQYXCUOIVOVLVQCVQUWANKEOKBNTWBRYDBRXDOORGYV(34x10)(28x4)EAYEMPUGGCQXXPYOUBNYDTWDKIIB(7x15)UVXKQLG(3x1)TKN(39x15)LHMQXTHAUBOBCOKWNNRBEHMHNAEZMXSYIRULNNX(6x8)UHNQYQ(42x12)YCCBHBGNBQWQITDZHCIWDQGBPJDWVSZLXBHFBZTNXX(70x13)(64x1)(3x6)IMA(50x1)(11x5)ZJWXZPRYZMS(3x6)DTK(8x2)HSRWFPBE(7x3)NQITYAF(550x15)(157x12)(4x15)CULH(63x7)(20x9)JKSLXREZWWMMUNGSFKKE(5x2)UHYAE(10x12)EVNMHFLJVG(4x14)LHLJ(72x1)(8x9)FHBNWEDX(2x7)LS(46x7)(8x5)BTBGGCGA(20x11)CMBXJXXVASRCEITYBBDS(1x6)I(5x13)WEXNR(367x2)(258x8)(59x4)(5x9)CGQVE(2x12)JU(23x5)ENUOLZGSAKUMZDPLUZJNORF(7x7)RWIMSVN(1x8)D(65x6)(22x11)LYMRFKDYRWHSPEFGZSSYAS(4x5)AOMJ(12x11)SJOTUWOGLFCP(3x5)PMB(108x15)(8x5)SFVFZKSV(3x3)URR(12x1)FLSFLNYPJWTL(32x12)KUBKDLJFAOCRQYHGGBQOLOLIKPYRFDDF(24x7)KYGCXSDUGCXKMEVUGKLUNZAT(95x11)(89x8)(12x9)BTUGSRSILKBV(18x6)EMUSAMBOMOYHVVSUEF(35x4)ZRVMFQWFDYPBYQXDOIIUMJQHAEDCZMYMPIW(1x9)H(713x7)(100x9)(2x5)EF(9x12)INJPHZJCG(72x2)(44x6)(4x15)XXWI(6x5)AKHVXV(1x12)F(3x2)KVK(2x12)NY(7x4)(1x12)S(5x2)NEPVZ(51x3)(34x1)(28x6)NLMEUVGWHSYSYVDMEGANJVPEZXXA(6x2)JZAWJK(173x9)(102x12)(6x3)(1x5)B(13x3)(7x13)NOJZEUQ(31x8)(3x10)CPP(15x10)XAMXQGQDXTMFFFJ(22x2)KXEPHSRHLAXWVTHUYYUOTQ(2x2)KI(24x14)(9x6)(4x8)CKZS(5x8)BGFNE(25x13)(8x3)IAZDNLPS(7x5)(1x13)V(345x1)(120x3)(61x12)(7x2)OEXPXRI(8x9)ARTERVYM(5x15)SVVHZ(8x9)KQKRQEQK(6x15)YPHUXP(13x7)(8x1)NYSDSLED(18x11)CBFTYQPXNDDMUSKBWA(2x12)AG(28x13)WNMFOTJZKSECVJNQGELGGFOVFXLH(138x8)(4x3)PAHR(29x15)(3x5)WVI(6x6)RBHYPB(5x8)XJGYF(68x7)(6x1)DKUUZV(3x10)FSZ(15x15)VBVSBJQQAMVQOFL(20x6)WXKJNUAQTMIWBFKEQBRG(12x11)WCUUSCREKMDI(7x15)(2x3)EU(18x10)(12x5)CIWKIUYZVFYC(11x1)(6x1)YTFEVP(14x3)AMZRUYKIEJEWGQ(2935x2)(747x7)(740x3)(152x6)(113x14)(63x7)(6x10)AROZFB(14x13)EEJUWNZBXBSJZB(7x7)ZTEZZAY(11x10)BZWJRMKJJXA(38x8)(1x8)M(26x7)ROFAUWBSJYYVFIZDCSULELNRMS(2x4)BM(7x11)XIMWVUI(6x4)(1x3)X(519x6)(92x9)(8x4)LWXAMAZO(2x6)HV(8x11)EZGATUUO(51x12)(4x4)NUQH(11x9)OYVORNQUUSY(6x12)LIYPIM(7x10)SBRMRZG(25x15)GMQEAMMROFEFMFCVBCDEDYCUK(103x1)(9x13)ZOPUZDBTZ(74x5)(33x3)HYGWJEAOUSOKTLFRDEWQYBSUUXTOZYEBW(11x12)FJKKFKWXZHI(3x2)WUK(4x4)UJSL(3x1)HTZ(147x12)(35x14)(9x3)DFLUOQIYB(15x7)ZSPVSVKOJIPWUNV(35x1)(4x4)QRXE(6x11)UFEDJL(9x6)ETFEROGHR(2x2)TT(50x13)(6x2)NBRGKE(14x1)FXYCOCFDTZXIEB(3x12)CPZ(5x3)YMGBR(116x13)(8x4)JYLJKJKO(52x5)(1x11)I(6x12)YTILES(2x13)XS(12x13)XIPTOZBANYYW(1x5)H(39x7)(12x15)IXXTDKZGZRIK(5x10)YGRYH(3x11)XGE(49x3)(43x9)(14x7)CBYKYWLCYCUISY(16x10)(3x8)NCB(2x14)ZJ(2173x9)(349x1)(198x12)(61x9)(42x3)(14x9)RXWYSJPPXVPEMH(2x2)CL(9x15)QLRYLZMJN(7x12)IVFTFHV(123x13)(11x2)RIGKDVWVFCK(15x13)KHGADJXLFQFVCID(43x14)JGKCHVWUFQPGCKOCSCEEDREVYKZUQOJYIYHMTBFTWKB(17x5)(2x10)RF(4x8)AAJL(5x10)KMGNT(61x4)(55x6)(8x11)RFUVGZGW(6x8)CWTPUZ(2x11)OI(15x14)IUUASQAUMTWLMYY(23x10)OTJBICKKDRZTLPMZSAGSKHE(6x13)KIDQQB(27x11)(9x7)ITZNVFMOM(7x12)KRJUTYV(481x10)(1x14)O(234x13)(19x14)VXFRZPOBQEPHZWUVPZA(194x15)(55x3)(23x2)OBUKIGZARPOUCKQKOCEWMNK(20x4)VHQCGAAJZBPDSAIKEVKU(13x13)WKSTPDBGYDIYI(24x4)(18x3)HYAFTYSAAOZACFKQNF(77x8)(3x9)IKC(26x8)MPLJVLHPCBCLQRKKSQVJUWLNPO(1x1)Y(13x3)ACIQYDRERJQPZ(7x7)BFZRAMT(1x2)V(224x12)(114x9)(16x14)(10x6)JGTPXHCKNM(10x12)XFSPPJPNLZ(4x9)MOQE(6x7)YIJANW(47x12)(21x7)XXXITCBDMXQALYVBIJZVD(14x9)BQEJZGPFQCLASY(26x2)(20x5)ZOIORXWFPWHOCUBYHLVH(57x14)(7x7)(1x14)S(2x14)LO(1x10)E(24x5)JRUQQVXLYMRJKEKCBUHHAXJB(1x11)B(1319x13)(533x3)(60x8)(12x5)CRSDECKETUKT(24x11)(9x12)EPAZHOCCB(3x11)YPV(5x12)RKIZQ(32x14)(13x11)(8x7)OBFWCEWY(7x8)LVXUCHZ(112x4)(86x14)(35x10)UAUAKCVFVWFUTVIMZKJVJSDLDKVVEHHEWES(10x15)GWMVEHCXRJ(15x6)ZOMXFSGCSMDQADO(1x4)D(12x11)YHYROORNKOOT(185x2)(44x1)(1x13)R(22x3)PECPELESXBNKNJYONHXKDW(3x15)BCZ(46x8)(31x15)EYMKMMRCNKAEXTOVHXYJGYRZSBZGTBR(3x3)YPE(17x4)AWZSWBGSORXCEDWEA(9x9)EOVQMSRLK(39x13)(2x14)FO(2x9)ZL(17x10)RDKXMAIWMJRNZCDNQ(110x9)(26x13)(4x5)AUXG(4x1)NKYZ(2x11)HM(12x2)(7x1)UYBISPR(21x12)WZFRACCFTYJYNYEBYDMWJ(25x3)(6x14)JQZIPJ(8x7)RYDRUQXE(9x14)WOIJUCMLC(62x1)(29x4)(13x1)PVZJAFZHCMKAD(4x14)DAAY(20x15)VXKSLRVAYJMDUAPZORZK(247x2)(1x12)C(146x13)(96x2)(20x5)MEXWMGWRESSUQLUNSKTQ(25x1)ENSINNLBWLXNKIVALELWWNLKT(4x11)EJAG(16x6)YFSVCDTGLMPBBVHH(2x5)IN(13x6)(8x9)JDSKGYVZ(11x3)(6x1)CWRMKZ(3x6)QGW(79x15)(8x9)JPMDKSUM(9x2)IEYSLSGHL(3x15)RJI(23x3)YBANOYRBOSDTLUSVTOPIASQ(8x10)WYAERLOF(434x15)(3x6)EED(10x5)(5x4)HZYMT(102x6)(87x15)(20x14)IYERDTUWPOBLAXBINHIS(27x6)YOQYWTHZYGFABTICETEEMLNNJPD(13x8)CXMOKWRXGAZZU(3x3)JXC(3x9)MVV(271x7)(20x6)IIHYPRNXHIVBYHWDOFZV(131x4)(2x15)TQ(40x3)EQOBUJXYUKNXRGHLRTKRYOHJNIWMAGNQDZIZCWZD(8x4)DFBSWLKP(28x12)XWOBMJVXWJAXIKOJDTVEPCHYJFBF(23x9)PCPQKRUGQNAZKIALGLVLJPE(1x8)I(14x5)YNKFVNTIGYUUEY(75x6)(1x15)L(15x5)CGTMUYBZXQZWKQX(21x7)YWCFVFFMZKXYGVEEPRVHT(6x6)AUFAKV(3x14)AFE(16x11)(3x15)XZR(2x5)FW(15x6)(9x12)JQUXZGTYC(102x5)(33x6)(4x14)VAKD(5x1)UFHXC(8x6)WYVCFYNW(4x7)VHWF(9x12)ZAFCJQEBF(4x4)GFAE(24x1)TTWSFNEPHVIFUZTSVGYVEHQU(156x2)(86x11)(10x4)JBGAPKEXGN(22x11)FVCUNKIMMVGDMYJKNMAZBP(14x2)QASMZHHHAQFIGR(15x8)WPZLJSRULHJVVFP(32x2)(4x15)PBUR(6x3)DMQCLZ(6x1)MHKQTY(18x15)SDIZPLVBRGOXNOKXMS(21x8)(8x4)CJVQZEBK(3x4)ARX(11x3)EVRICTWKIDT(6x1)BJLPZP(78x14)(9x8)(4x9)FFUW(14x15)CEWZNPRCESFWHZ(36x11)ITXHTYZRAPVDXJEZHBWMPIFNZUDTMVEGRMIC";
    }
}