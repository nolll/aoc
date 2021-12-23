using App.Common.CoordinateSystems;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace App.Puzzles.Year2021.Day22;

public class Year2021Day22Tests
{
    [Test]
    public void IsCoordWithin()
    {
        var area = new RebootArea(new Matrix3DAddress(0, 0, 0), new Matrix3DAddress(10, 10, 10));
        var result = area.IsCoordWithin(new Matrix3DAddress(5, 5, 5));

        Assert.That(result, Is.True);
    }
    
    [Test]
    public void GetOverlapCornerCount1()
    {
        var area1 = new RebootArea(new Matrix3DAddress(0, 0, 0), new Matrix3DAddress(10, 10, 10));
        var area2 = new RebootArea(new Matrix3DAddress(5, 5, 5), new Matrix3DAddress(15, 15, 15));
        var result = area1.GetOverlapCorners(area2);

        Assert.That(result.Count, Is.EqualTo(1));
    }

    [Test]
    public void GetOverlapCornerCount2()
    {
        var area1 = new RebootArea(new Matrix3DAddress(0, 0, 0), new Matrix3DAddress(10, 10, 10));
        var area2 = new RebootArea(new Matrix3DAddress(2, 2, 2), new Matrix3DAddress(8, 12, 12));
        var result = area1.GetOverlapCorners(area2);

        Assert.That(result.Count, Is.EqualTo(2));
    }

    [Test]
    public void GetOverlapCornerCount3()
    {
        var area1 = new RebootArea(new Matrix3DAddress(0, 0, 0), new Matrix3DAddress(10, 10, 10));
        var area2 = new RebootArea(new Matrix3DAddress(2, 2, 2), new Matrix3DAddress(8, 8, 12));
        var result = area1.GetOverlapCorners(area2);

        Assert.That(result.Count, Is.EqualTo(4));
    }

    [Test]
    public void GetRemainingParts_CornerOverlap_LeftBottomCloseOverlapping()
    {
        var area1 = new RebootArea(new Matrix3DAddress(0, 0, 0), new Matrix3DAddress(2, 2, 2));
        var area2 = new RebootArea(new Matrix3DAddress(1, 1, 1), new Matrix3DAddress(3, 3, 3));
        var result = area1.GetSortedRemainingParts(area2);

        Assert.That(result.Count, Is.EqualTo(3));
        Assert.That(result[0].From, Is.EqualTo(new Matrix3DAddress(0, 0, 0)));
        Assert.That(result[0].To, Is.EqualTo(new Matrix3DAddress(0, 2, 2)));
        Assert.That(result[1].From, Is.EqualTo(new Matrix3DAddress(1, 0, 0)));
        Assert.That(result[1].To, Is.EqualTo(new Matrix3DAddress(2, 0, 2)));
        Assert.That(result[2].From, Is.EqualTo(new Matrix3DAddress(1, 1, 0)));
        Assert.That(result[2].To, Is.EqualTo(new Matrix3DAddress(2, 2, 0)));
    }

    [Test]
    public void GetRemainingParts_CornerOverlap_LeftTopCloseOverlapping()
    {
        var area1 = new RebootArea(new Matrix3DAddress(1, 1, 1), new Matrix3DAddress(3, 3, 3));
        var area2 = new RebootArea(new Matrix3DAddress(0, 0, 0), new Matrix3DAddress(2, 2, 2));
        var result = area1.GetSortedRemainingParts(area2);

        Assert.That(result.Count, Is.EqualTo(3));
        Assert.That(result[0].From, Is.EqualTo(new Matrix3DAddress(1, 1, 3)));
        Assert.That(result[0].To, Is.EqualTo(new Matrix3DAddress(2, 2, 3)));
        Assert.That(result[1].From, Is.EqualTo(new Matrix3DAddress(1, 3, 1)));
        Assert.That(result[1].To, Is.EqualTo(new Matrix3DAddress(2, 3, 3)));
        Assert.That(result[2].From, Is.EqualTo(new Matrix3DAddress(3, 1, 1)));
        Assert.That(result[2].To, Is.EqualTo(new Matrix3DAddress(3, 3, 3)));
    }

    [Test]
    public void GetRemainingParts_EdgeOverlap_LeftBottomOverlapping()
    {
        var area1 = new RebootArea(new Matrix3DAddress(0, 0, 0), new Matrix3DAddress(3, 3, 3));
        var area2 = new RebootArea(new Matrix3DAddress(2, 2, 1), new Matrix3DAddress(4, 4, 2));
        var result = area1.GetSortedRemainingParts(area2);

        Assert.That(result.Count, Is.EqualTo(4));
        Assert.That(result[0].From, Is.EqualTo(new Matrix3DAddress(0, 0, 0)));
        Assert.That(result[0].To, Is.EqualTo(new Matrix3DAddress(1, 3, 3)));
        Assert.That(result[1].From, Is.EqualTo(new Matrix3DAddress(2, 0, 0)));
        Assert.That(result[1].To, Is.EqualTo(new Matrix3DAddress(3, 1, 3)));
        Assert.That(result[2].From, Is.EqualTo(new Matrix3DAddress(2, 2, 0)));
        Assert.That(result[2].To, Is.EqualTo(new Matrix3DAddress(3, 3, 0)));
        Assert.That(result[3].From, Is.EqualTo(new Matrix3DAddress(2, 2, 3)));
        Assert.That(result[3].To, Is.EqualTo(new Matrix3DAddress(3, 3, 3)));
    }

    [Test]
    public void Part1()
    {
        var reactor = new SubmarineReactor();
        var result = reactor.Reboot(Input1);

        Assert.That(result, Is.EqualTo(39));
    }

    [Test]
    public void Part1Advanced_WithInput1()
    {
        var reactor = new SubmarineReactor();
        var result = reactor.Reboot2(Input1, 50);

        Assert.That(result, Is.EqualTo(39));
    }

    //[Test]
    //public void Part1Advanced_WithInput2()
    //{
    //    var reactor = new SubmarineReactor();
    //    var result = reactor.Reboot2(Input2);

    //    Assert.That(result, Is.EqualTo(590784));
    //}

    //[Test]
    //public void Part1Advanced_WithInpu3()
    //{
    //    var reactor = new SubmarineReactor();
    //    var result = reactor.Reboot2(Input3);

    //    Assert.That(result, Is.EqualTo(0));
    //}

    //[Test]
    //public void Part2()
    //{
    //    var result = 0;

    //    Assert.That(result, Is.EqualTo(0));
    //}

    private const string Input1 = @"
on x=10..12,y=10..12,z=10..12
on x=11..13,y=11..13,z=11..13
off x=9..11,y=9..11,z=9..11
on x=10..10,y=10..10,z=10..10";

    private const string Input2 = @"
on x=-20..26,y=-36..17,z=-47..7
on x=-20..33,y=-21..23,z=-26..28
on x=-22..28,y=-29..23,z=-38..16
on x=-46..7,y=-6..46,z=-50..-1
on x=-49..1,y=-3..46,z=-24..28
on x=2..47,y=-22..22,z=-23..27
on x=-27..23,y=-28..26,z=-21..29
on x=-39..5,y=-6..47,z=-3..44
on x=-30..21,y=-8..43,z=-13..34
on x=-22..26,y=-27..20,z=-29..19
off x=-48..-32,y=26..41,z=-47..-37
on x=-12..35,y=6..50,z=-50..-2
off x=-48..-32,y=-32..-16,z=-15..-5
on x=-18..26,y=-33..15,z=-7..46
off x=-40..-22,y=-38..-28,z=23..41
on x=-16..35,y=-41..10,z=-47..6
off x=-32..-23,y=11..30,z=-14..3
on x=-49..-5,y=-3..45,z=-29..18
off x=18..30,y=-20..-8,z=-3..13
on x=-41..9,y=-7..43,z=-33..15
on x=-54112..-39298,y=-85059..-49293,z=-27449..7877
on x=967..23432,y=45373..81175,z=27513..53682";

    private const string Input3 = @"
on x=-6..41,y=-12..39,z=-10..42
on x=-33..13,y=-34..15,z=3..47
on x=-6..47,y=-7..38,z=-23..28
on x=-10..37,y=-3..43,z=-11..38
on x=-42..7,y=-39..9,z=-29..22
on x=-11..37,y=-36..11,z=-34..12
on x=-31..13,y=-12..40,z=1..49
on x=-23..28,y=-7..44,z=-39..12
on x=-1..44,y=-48..3,z=-37..14
on x=0..49,y=-27..26,z=-33..12
off x=-13..0,y=35..45,z=6..15
on x=-41..6,y=-17..32,z=-22..29
off x=-25..-12,y=-44..-32,z=-19..0
on x=-31..21,y=-6..47,z=-2..45
off x=1..17,y=-13..-2,z=-48..-34
on x=-40..13,y=-4..48,z=-29..17
off x=17..29,y=-39..-30,z=-15..4
on x=-20..24,y=-18..27,z=-39..7
off x=7..20,y=-26..-12,z=-26..-8
on x=-37..8,y=-17..30,z=-14..38
on x=63674..72237,y=20683..37531,z=-35064..-16872
on x=-51990..-35385,y=-78503..-48525,z=-752..35650
on x=27632..33313,y=35477..62597,z=-58213..-50913
on x=65890..74495,y=-45869..-13775,z=-39225..-14722
on x=-275..16102,y=-72595..-60586,z=-53397..-23273
on x=-69158..-42553,y=45370..61812,z=-42421..-18663
on x=-78654..-58419,y=-30915..7322,z=-51094..-33929
on x=-1256..22317,y=37707..59544,z=-63046..-53164
on x=26513..44666,y=-55290..-34887,z=-62641..-49964
on x=-38394..-32826,y=20123..52430,z=-74302..-53761
on x=-76260..-48290,y=-35301..-11819,z=-36430..-22459
on x=54855..74218,y=-45492..-25796,z=5423..34586
on x=-60859..-42702,y=37095..58797,z=-42035..-17299
on x=25061..44950,y=-11087..4566,z=-76090..-58040
on x=-7719..1196,y=-84740..-56268,z=18595..40418
on x=37771..58776,y=34417..62574,z=-47992..-23102
on x=-21356..1356,y=-63790..-54279,z=32547..55070
on x=-8345..19180,y=-53204..-27521,z=-68280..-61850
on x=67534..81624,y=-31159..-14948,z=1049..12579
on x=55346..68022,y=7885..30928,z=-44155..-34352
on x=36305..74237,y=41145..52234,z=-42601..-28496
on x=-90070..-73989,y=-23814..-9394,z=14042..31716
on x=-84427..-54677,y=8904..30283,z=-1322..33502
on x=-71181..-41802,y=30646..57075,z=35746..53147
on x=38541..52970,y=-20791..-7785,z=51108..80150
on x=59180..82388,y=-3853..32838,z=-24341..-5768
on x=-56690..-39206,y=8232..29724,z=40440..64896
on x=21608..43080,y=60567..71466,z=40486..52408
on x=60372..77998,y=-28305..3238,z=14836..37414
on x=-4093..35198,y=10164..32918,z=-85387..-73526
on x=-43292..-12636,y=-9696..12766,z=64552..80970
on x=-28102..1261,y=-70258..-57055,z=-47806..-31344
on x=-63701..-56970,y=-47663..-38224,z=34022..46913
on x=-38997..-7735,y=-20643..-11524,z=-76648..-69429
on x=-511..8645,y=42010..62268,z=-58666..-40526
on x=16306..47865,y=-64952..-45421,z=53087..54589
on x=-16279..2136,y=-61390..-44811,z=50710..64292
on x=-7745..20078,y=386..12000,z=68727..90088
on x=64690..73403,y=-24946..-7208,z=-37627..-17433
on x=-90968..-67687,y=17270..37677,z=-13992..-2525
on x=18861..37721,y=-86406..-68095,z=-23372..-3258
on x=41065..48438,y=54874..73195,z=-283..27298
on x=45205..54225,y=-67863..-30873,z=-54709..-22614
on x=-10233..-3001,y=15582..31889,z=57592..89392
on x=-35101..-13894,y=-70592..-43271,z=37482..47874
on x=10843..37299,y=27094..49883,z=54316..68303
on x=56557..93573,y=-25293..2359,z=24320..47118
on x=17766..33710,y=56863..70640,z=15156..29617
on x=10910..21590,y=42930..65065,z=57606..76820
on x=-60175..-28682,y=928..18831,z=-65938..-54841
on x=-78055..-49879,y=34994..64428,z=-2418..2276
on x=59141..65590,y=33452..65433,z=-12600..-10439
on x=32409..48105,y=-43813..-13532,z=-83789..-55956
on x=-72650..-62087,y=30406..60429,z=17600..26813
on x=-90755..-67882,y=-36682..-5054,z=-21110..1198
on x=22223..47574,y=-4347..15805,z=-82271..-69276
on x=-76178..-49716,y=-21343..-3479,z=43309..50309
on x=23918..51383,y=46032..80222,z=-38284..-33927
on x=9063..30200,y=-14090..13010,z=66331..92110
on x=-9117..18211,y=-91446..-67159,z=-38983..-15166
on x=-84040..-64286,y=14208..17723,z=8226..42068
on x=30663..49357,y=56472..65567,z=21785..35391
on x=49515..62793,y=-65937..-43950,z=-3599..3658
on x=50191..73902,y=-45655..-19740,z=34457..46986
on x=29380..39669,y=-44098..-5640,z=66799..71770
on x=68464..78505,y=-49399..-17076,z=-404..19557
on x=-50618..-23493,y=-86374..-65393,z=14291..36383
on x=-62993..-39175,y=-35991..-5866,z=50864..70363
on x=47662..56935,y=21433..54255,z=41743..62223
on x=-50812..-34320,y=48864..66709,z=10296..36222
on x=-51511..-38702,y=31283..59283,z=29440..44647
on x=31683..59429,y=-68371..-43693,z=-34024..-4934
on x=-66814..-57275,y=-56376..-31172,z=-17978..7865
on x=-24839..-1406,y=-71938..-40830,z=37293..54028
on x=-65450..-42663,y=16690..39141,z=-52553..-22761
on x=57568..68488,y=-56872..-27713,z=-51410..-21887
on x=9816..46885,y=-18028..1846,z=-86212..-61019
on x=54133..63512,y=-30827..-23276,z=45415..57776
on x=34872..65256,y=-41153..-10659,z=-72176..-50005
on x=45369..65188,y=30335..65462,z=24802..56968
on x=48848..59043,y=-32654..-4256,z=-67300..-37161
on x=-38563..-28359,y=-51416..-42490,z=-76819..-47617
on x=5064..28753,y=39709..72294,z=57340..76529
on x=-62140..-41501,y=-56988..-40595,z=-55398..-25076
on x=12105..35514,y=-36094..-18861,z=66054..68875
on x=-76182..-50302,y=-51373..-29014,z=-58038..-27014
on x=37302..53874,y=27894..53613,z=29583..50665
on x=16147..34480,y=21511..30921,z=62835..79807
on x=-22134..-1214,y=-70806..-50856,z=36851..68884
on x=-68030..-39601,y=-25612..-7027,z=45246..53743
on x=46455..63099,y=-39255..-17799,z=-60376..-32427
on x=9037..17238,y=-81020..-75940,z=-17153..4464
on x=-58302..-44073,y=38209..74196,z=-22601..-16540
on x=12217..43506,y=-49758..-19201,z=55186..83277
on x=60852..70701,y=-13934..5616,z=-54213..-23590
on x=-30770..-12014,y=-79992..-69814,z=-26312..640
on x=-29591..-1817,y=64139..78606,z=-54458..-38340
on x=-70606..-49521,y=23833..37444,z=27457..58896
on x=-13543..7851,y=-80973..-64115,z=6135..31772
on x=-87056..-60133,y=8563..28255,z=30595..34751
on x=-52703..-41244,y=-71153..-48612,z=9932..47505
on x=4823..15333,y=8479..32983,z=-94904..-72911
on x=20706..34913,y=-32841..-21091,z=-78732..-64240
on x=34179..38502,y=-77966..-58490,z=29443..56467
on x=-3207..15375,y=-37001..-15828,z=57339..80701
on x=-40727..-27410,y=9776..32591,z=60147..82181
on x=-90458..-67516,y=-21897..-17898,z=-46698..-19679
on x=70001..85013,y=20139..39366,z=3263..10448
on x=38509..50837,y=51063..75538,z=10565..22103
on x=-4360..16665,y=-75325..-44314,z=34199..53160
on x=-30672..-24565,y=-67654..-57579,z=-50202..-40567
on x=-931..5535,y=5154..21429,z=73534..79225
on x=-56373..-39111,y=-9192..16483,z=47031..75102
on x=58111..79237,y=-40333..-23947,z=-33476..-13221
on x=-13691..-355,y=-92671..-58545,z=-35141..-18833
on x=-17942..-7697,y=-79775..-50292,z=-56054..-29671
on x=-19883..18823,y=-40243..-12211,z=68158..91839
on x=28227..45243,y=-82001..-49839,z=-18511..-400
on x=35090..66081,y=48542..63078,z=-35332..-9723
on x=-39870..-23865,y=-3314..960,z=-92361..-64957
on x=6533..15219,y=-80248..-78662,z=-9878..13965
on x=57321..67145,y=-21481..-730,z=43503..66453
on x=-44052..-20551,y=72872..77681,z=-30093..-9429
on x=51925..68298,y=-31201..-4633,z=38195..69628
on x=10414..27608,y=-4566..19901,z=64702..79019
on x=19786..41539,y=-11985..3510,z=-89078..-62585
on x=-69134..-57899,y=-14537..-2930,z=43609..57217
on x=-63294..-39608,y=-48334..-38499,z=33627..49867
on x=-13641..-838,y=-59458..-47752,z=61695..81638
on x=26262..47900,y=-71939..-67371,z=-2327..11490
on x=41397..67113,y=20446..27838,z=55192..69727
on x=-61415..-42631,y=-79824..-50456,z=-15994..7366
on x=-13162..-5678,y=70097..96740,z=-18064..405
on x=-77814..-46506,y=41557..55792,z=-5638..18741
on x=-77342..-55583,y=-40514..-22334,z=-50171..-25631
on x=38632..49601,y=41232..51499,z=-48303..-41017
on x=-53506..-24096,y=-87035..-66409,z=-9127..18615
on x=26165..40921,y=-84915..-71424,z=-3718..19495
on x=-4939..316,y=68646..96298,z=-26103..-13038
on x=31384..41505,y=19786..42641,z=-63672..-41466
on x=-60916..-38182,y=35016..70898,z=3366..31295
on x=29127..56862,y=24709..42869,z=50818..70920
on x=-51895..-33510,y=-54721..-38640,z=-73230..-54388
on x=-38104..-7732,y=18585..49865,z=51762..81590
on x=-78409..-65644,y=-14757..1055,z=29317..46620
on x=-96121..-65386,y=-7080..9280,z=13143..31964
on x=19149..41215,y=54709..69355,z=27575..43807
on x=-6002..19842,y=-95609..-64945,z=-32982..-8121
on x=6766..25889,y=-5640..13107,z=-89762..-67299
on x=33913..56013,y=-5283..28454,z=-80385..-65032
on x=6520..20460,y=-12445..23380,z=68806..93368
on x=67990..85138,y=26848..42404,z=-19133..1267
on x=-46060..-30689,y=20663..39885,z=-83854..-60641
on x=7998..21638,y=128..20189,z=70069..95243
on x=-23661..35,y=31127..50322,z=64699..87354
on x=-77503..-66864,y=-32895..-14398,z=-799..11838
on x=68689..83438,y=33792..47001,z=13803..24780
on x=35200..63053,y=-72724..-57829,z=28598..48817
on x=33541..39159,y=-76699..-45279,z=-53346..-26573
on x=21855..50691,y=41850..61559,z=25889..30388
on x=-10341..12939,y=-83801..-74421,z=-43721..-22149
on x=41566..58825,y=-6013..9212,z=-67757..-53445
on x=-33298..-26814,y=-77187..-73171,z=-6765..6769
on x=50984..64174,y=5063..31458,z=-62536..-34031
on x=2531..21997,y=-1109..24717,z=61742..84665
on x=5418..29671,y=28878..51538,z=58254..76730
on x=-83857..-52171,y=-24547..-712,z=-52592..-26440
on x=55853..92892,y=-44129..-20969,z=-9579..19961
on x=-84947..-64675,y=-30189..2305,z=-44890..-28965
on x=-28461..-4215,y=-59739..-28350,z=59689..84997
on x=7888..15476,y=68561..90567,z=-31549..-25297
on x=-77376..-64592,y=-7002..5445,z=-27633..-22069
on x=-72213..-57730,y=19725..38219,z=-20612..9450
on x=38374..47719,y=62027..78647,z=-20441..1989
on x=-59539..-40304,y=16392..31994,z=-69591..-41689
on x=68727..76497,y=31619..37304,z=-13164..14981
on x=-21271..-19001,y=-28011..-2985,z=67597..81350
on x=53409..87331,y=-29583..-6602,z=33003..48125
on x=-37664..-10296,y=-31918..-5544,z=56130..94454
on x=-32100..-17518,y=-2858..2104,z=60294..83679
on x=-81260..-59750,y=-47909..-23357,z=-13117..4355
on x=2573..25666,y=44659..59226,z=-71952..-53644
on x=38838..58838,y=-48561..-33680,z=37130..57850
on x=-66344..-54705,y=-45266..-30262,z=43894..53708
on x=-94174..-72558,y=-24772..-20354,z=1992..34790
on x=55181..56006,y=35125..59116,z=-45434..-27501
on x=-60741..-39326,y=40413..69438,z=-30159..-8171
on x=-77353..-41928,y=41200..66979,z=-2085..14986
on x=-66437..-43792,y=-33289..-17174,z=-49434..-24720
on x=56936..78176,y=-25562..-22200,z=11817..32920
on x=38682..56986,y=29150..58809,z=-63106..-37678
on x=26960..32647,y=59932..85348,z=-30928..-27105
on x=-48179..-25795,y=8569..19633,z=59174..77033
on x=-35849..-13828,y=-27865..-13801,z=-95683..-59887
on x=65572..87510,y=3995..14192,z=-15309..11354
on x=-57000..-36998,y=48763..52396,z=12478..46083
on x=-94430..-64900,y=-29634..-9456,z=-10324..7509
on x=-80454..-62603,y=-29724..-10752,z=-24548..-4590
on x=64172..91747,y=-53676..-21558,z=-12996..21143
on x=50230..73411,y=-58434..-53040,z=5316..17390
on x=-63114..-59063,y=50568..51092,z=-32974..-6748
off x=-5346..12828,y=-94065..-66684,z=16653..41590
off x=-48413..-31269,y=-30982..-16844,z=52979..82109
off x=-27146..-12627,y=38532..48564,z=-69504..-65213
off x=-62163..-52037,y=19703..35908,z=39621..58499
on x=18484..52167,y=6099..26595,z=68343..80461
off x=24892..57922,y=37369..52514,z=31418..66347
on x=63228..73398,y=11870..44151,z=17323..42325
on x=-88276..-54188,y=-20551..8179,z=-42723..-27996
off x=37150..49731,y=56211..65202,z=18159..36718
off x=759..23479,y=61624..84124,z=30767..51873
off x=-47695..-13347,y=-14372..13349,z=-81335..-60381
on x=61451..74464,y=32577..36792,z=21339..32855
on x=70117..88446,y=22440..40635,z=-23918..-2599
on x=-3372..27478,y=53047..55940,z=-58566..-55905
off x=-24720..-4607,y=-51176..-34317,z=-76211..-48309
off x=49813..72946,y=-68748..-48153,z=8998..24857
off x=10128..22661,y=49484..57338,z=56927..77820
off x=-9470..7258,y=26533..47722,z=-78365..-59389
off x=-30938..-19988,y=-66375..-47763,z=40111..65871
off x=-15752..12998,y=-43267..-24156,z=70932..77311
off x=-53113..-22807,y=56287..77523,z=39665..50328
off x=49218..63565,y=15387..34092,z=49663..57280
off x=-22722..-11723,y=36042..54943,z=55612..56869
on x=9214..34469,y=41515..60872,z=45203..60987
off x=-82597..-59056,y=15777..27066,z=-43969..-18837
on x=-77176..-51830,y=22534..37606,z=26588..53948
on x=-70071..-41653,y=-38160..-31571,z=31586..65248
off x=45744..76075,y=-44123..-28805,z=-38054..-29692
off x=-38298..-28858,y=-14082..12865,z=61767..83479
on x=13285..35714,y=-51377..-35050,z=-62043..-36816
off x=-47120..-32382,y=-29818..-24801,z=-77642..-48390
off x=25300..59604,y=60040..81118,z=9188..25901
off x=17501..43646,y=-90926..-59732,z=14861..32903
off x=-21581..-13788,y=70050..88660,z=31186..47396
on x=42896..51969,y=-30625..-7642,z=-71811..-59326
on x=-38436..-7766,y=4909..33968,z=-75490..-72143
off x=67433..81719,y=16275..42103,z=16334..33966
on x=24560..46723,y=7349..26100,z=-87848..-67158
on x=54459..60502,y=-7264..14707,z=-70681..-38277
off x=62626..80661,y=-26777..-17366,z=-13182..22497
on x=-29835..-17313,y=61842..84337,z=-14176..9503
on x=21626..49917,y=66635..89641,z=7779..26313
off x=-69016..-46360,y=15767..50156,z=51148..54109
on x=-73883..-60761,y=32637..47442,z=-11608..6111
on x=-7112..17909,y=-22404..-8276,z=-85638..-74005
off x=7165..21843,y=-75219..-73066,z=15372..43309
off x=-8947..-2271,y=36894..40424,z=69361..86893
off x=7284..34464,y=5094..12925,z=75395..95662
off x=45088..65605,y=20..26443,z=-59729..-36467
off x=35462..58778,y=-15582..4436,z=-71756..-47447
on x=17138..34096,y=-12276..11290,z=58045..84339
off x=-71294..-43548,y=-3191..20491,z=28864..59825
on x=71136..88119,y=-13007..8497,z=-31546..-13394
on x=-66159..-34407,y=50856..70170,z=4329..21758
on x=59924..67943,y=-46292..-37846,z=4555..36150
on x=-5220..26388,y=-93678..-64914,z=16201..34587
off x=68404..78854,y=-30125..-12290,z=-17499..-9597
on x=-71834..-54721,y=20467..49657,z=30418..55871
off x=44222..64181,y=18628..41560,z=53406..64478
off x=50918..75592,y=-5396..25677,z=27123..50574
on x=1124..21450,y=-20615..-823,z=67756..78343
on x=67407..96331,y=4371..34552,z=-14306..4876
on x=-26803..-3596,y=-35625..2143,z=59040..92456
off x=18169..40528,y=-22523..-3794,z=66964..88640
on x=6463..27266,y=61806..71904,z=25555..51514
on x=-39547..-24814,y=58888..79868,z=33124..52709
on x=20892..50714,y=67492..87674,z=-27670..-15067
off x=-67264..-43510,y=47960..59733,z=-9127..24268
off x=-73737..-55042,y=30319..46082,z=-8497..18489
off x=-51433..-27062,y=50938..69924,z=-43465..-14345
on x=-38429..-19065,y=-82975..-55502,z=-30949..-23260
on x=51205..78828,y=-55993..-33519,z=14645..42834
off x=-59552..-43106,y=-64460..-40283,z=-61439..-32533
on x=-39331..-11511,y=-12552..-7027,z=-94622..-61735
on x=-86611..-57671,y=18328..51342,z=11389..24360
off x=-13622..18619,y=-24759..1869,z=77922..98690
off x=52623..86840,y=-49607..-28046,z=-23258..823
off x=-60395..-34712,y=-39820..-26646,z=56815..60497
off x=-20740..2337,y=32965..42069,z=-81437..-53054
on x=-56455..-28922,y=50933..72057,z=-39639..-19962
off x=-17894..10492,y=-84804..-61552,z=-27802..-11116
on x=-14603..12706,y=8965..21446,z=-88021..-66985
off x=56915..92356,y=15835..27030,z=-29464..-7484
on x=-30570..-12286,y=-29691..-19642,z=57541..87534
on x=42817..68030,y=5120..16052,z=54789..65079
off x=24399..59944,y=-27672..-5436,z=-67565..-54256
on x=69755..79379,y=-26515..-932,z=-36705..-9894
on x=-3295..20379,y=56783..82573,z=24516..50130
off x=12453..32187,y=55459..75001,z=20124..27924
off x=25556..40350,y=68256..80624,z=-25749..166
off x=-4847..4618,y=-74111..-57007,z=39425..52253
off x=31512..54748,y=-48152..-36753,z=52492..72230
off x=-12486..1048,y=58617..92994,z=16135..23160
off x=-24140..1564,y=59108..71650,z=34404..51089
off x=47964..73086,y=-45483..-28013,z=22883..54622
on x=-40099..-32344,y=-22098..-13332,z=68192..89293
on x=4500..20377,y=-51267..-33867,z=69402..83492
on x=52569..81961,y=-53403..-24061,z=1978..17679
off x=36770..57506,y=-4952..12087,z=55047..74004
on x=67554..73756,y=-44519..-20657,z=12122..18741
off x=35515..51114,y=11680..15294,z=59339..76191
on x=58862..86316,y=-20952..-14155,z=34840..38045
on x=-14592..12446,y=-29111..-24802,z=56671..79591
on x=-23543..-11985,y=-74819..-64618,z=-44703..-15267
off x=-37413..-8170,y=32425..49738,z=47995..66020
off x=41035..54417,y=45072..77846,z=-26156..-7275
on x=-41749..-11663,y=-92510..-69606,z=1999..29221
off x=48868..79698,y=-28992..-5540,z=47520..61486
off x=-61620..-41801,y=40715..52508,z=5782..34869
off x=51744..64784,y=13007..37571,z=32567..65530
off x=-89126..-65770,y=-31978..-13182,z=7976..34630
on x=2249..18061,y=75961..81050,z=-18799..5551
off x=62332..74145,y=12152..31203,z=25298..50746
on x=53318..81180,y=-31592..-12758,z=-53847..-32790
off x=5713..26084,y=63088..86549,z=-54529..-21638
on x=-89462..-62777,y=11696..16699,z=558..6174
off x=-74726..-49998,y=-24193..13297,z=-63830..-40164
on x=51662..77838,y=22383..40369,z=15700..37129
on x=-52337..-47233,y=-49555..-34457,z=47152..57885
on x=-2966..17387,y=-53364..-35406,z=-81895..-64688
off x=13205..46842,y=-82921..-60151,z=19042..41349
on x=66771..97228,y=5251..23596,z=12694..17913
on x=-71272..-54724,y=-53515..-21787,z=-18838..8939
off x=-65104..-46707,y=-9234..15580,z=36150..66720
on x=-85754..-63553,y=35346..45469,z=-11608..10829
on x=-43549..-27396,y=58529..68624,z=-30116..-15328
on x=-69125..-48641,y=22773..41447,z=18939..42796
off x=26012..47769,y=-76467..-48405,z=-20843..-14915
on x=-23752..-10052,y=1078..17684,z=67913..83159
on x=361..17866,y=-87165..-65868,z=-53407..-14724
on x=32457..51888,y=2427..30866,z=53243..75857
off x=1086..28257,y=71033..79472,z=16654..44669
on x=64570..81699,y=-178..29268,z=30157..55657
off x=-49173..-29897,y=63145..76697,z=15633..32917
on x=-45818..-16924,y=-24913..-11164,z=-84543..-54123
off x=-77646..-60090,y=17523..35846,z=-36127..-14895
off x=-39793..-16349,y=-34389..-17105,z=64143..73522
on x=179..21799,y=60556..77155,z=-41535..-6446
on x=-12196..685,y=47424..56102,z=-64429..-58332
on x=30726..50777,y=-7477..21328,z=-86354..-57028
off x=47339..69901,y=-26683..-14653,z=-56389..-21754
off x=58834..75585,y=15510..40650,z=-57490..-22849
on x=-33628..-9451,y=49680..53262,z=-58740..-43060
off x=-71539..-46149,y=34327..56377,z=-27208..-23412
on x=-89074..-73728,y=21316..39800,z=-13001..-6986
off x=7927..26428,y=-54041..-43829,z=-77144..-55616
on x=-71393..-41736,y=-4474..23943,z=45755..76357
off x=-3132..30888,y=-85359..-61796,z=-8462..-45
on x=-40975..-26298,y=26200..60520,z=-71698..-59092
off x=-56889..-42195,y=34074..42106,z=-48559..-31484
on x=-837..24047,y=34548..59026,z=39428..78547
on x=-60299..-32195,y=40520..63885,z=-47793..-36527
on x=76142..94075,y=-13314..22610,z=10050..22939
on x=-3248..2027,y=-38427..-17604,z=-93558..-72784
off x=25635..41478,y=-83062..-67853,z=-4985..10325
on x=-7096..2044,y=-6776..22218,z=-89547..-63688
on x=-6369..8953,y=75013..85185,z=14852..23714
on x=48056..70720,y=36283..57489,z=-900..19511
off x=23346..43021,y=25101..40085,z=-79574..-59090
off x=16946..27550,y=-78605..-47815,z=30802..53898
on x=-47332..-20930,y=62034..86891,z=1865..9667
on x=-56270..-27890,y=26782..49585,z=54423..61423
on x=-1792..10179,y=-84862..-56581,z=-38960..-20686
off x=-71551..-34506,y=35052..55302,z=-53055..-19634
off x=-68036..-52737,y=27235..38752,z=-51882..-43819
on x=32113..47272,y=-80099..-59288,z=5922..16248
off x=-2298..34809,y=-87824..-49005,z=32443..46459
on x=63869..89095,y=-38059..-22076,z=-25331..-4453
off x=-19408..-9898,y=-29196..-13012,z=68994..91275
on x=-33380..-17870,y=49041..58372,z=-59965..-45839
off x=18855..24560,y=-26226..-540,z=-89420..-76709
on x=13397..44610,y=-35375..-9105,z=-81220..-53608
off x=55453..65989,y=50126..56333,z=1952..16210
off x=55932..70104,y=-43882..-35225,z=-37932..-3942
off x=-80015..-58260,y=16195..41548,z=27114..46661
off x=-9843..17058,y=46798..66680,z=43972..81134
on x=59065..70902,y=25178..48728,z=-42628..-22735
off x=12074..35300,y=-56497..-28349,z=-76487..-55666
on x=64962..89471,y=19547..29810,z=13457..31316
off x=-23945..-3959,y=60955..84552,z=-14433..-5176
on x=-2499..23401,y=-9120..8372,z=76233..84081
off x=-91662..-61207,y=-3301..15344,z=27899..48015
on x=31081..44643,y=-28448..-8595,z=61457..85782
off x=-7126..5620,y=4729..33668,z=71078..80278
on x=-55513..-28549,y=19456..40375,z=54812..59238
off x=-72784..-69055,y=15210..29345,z=23446..42106
on x=-31167..-20878,y=-72954..-57958,z=18134..32662
off x=-39385..-25743,y=-86061..-63416,z=15356..33521
on x=-1125..19521,y=41370..69606,z=-73796..-45622
off x=45588..66056,y=12521..25197,z=48790..62861
on x=47627..68254,y=31882..53328,z=25662..42038
on x=-34092..-17401,y=-5453..15487,z=-87812..-59554
on x=62848..70259,y=-51016..-19941,z=23951..44004
on x=-43524..-29947,y=10914..35479,z=67143..70490
on x=3631..13773,y=-95804..-70033,z=-18547..-6193
on x=-11759..9957,y=6506..27819,z=70712..94866
off x=-86705..-61424,y=-26069..594,z=21267..36321
off x=-73433..-52379,y=-46684..-33106,z=-51920..-32215
off x=-55321..-48322,y=13236..27338,z=-64006..-44521";
}