using AwaitHandleSample;

//Stage 1 
// var horo = new HoroService();
// var taurus = await horo.MakeDailyHoroscopeBySign(HoroService.ZodiacSign.Taurus);
// var scorpio = await horo.MakeDailyHoroscopeBySign(HoroService.ZodiacSign.Scorpio);
//
// Console.WriteLine(taurus);
// Console.WriteLine(scorpio);


//Stage 2
// var horo = new HoroService();
// var taurus = horo.MakeDailyHoroscopeBySign(HoroService.ZodiacSign.Taurus);
// var scorpio = horo.MakeDailyHoroscopeBySign(HoroService.ZodiacSign.Scorpio);
//
// await Task.WhenAll(taurus, scorpio);
// Console.WriteLine(taurus.Result);
// Console.WriteLine(scorpio.Result);

//Stage 3
 // var horo = new HoroService();
 // var taurus = horo.MakeDailyHoroscopeBySign(HoroService.ZodiacSign.Taurus);
 // var scorpio = horo.MakeDailyHoroscopeBySign(HoroService.ZodiacSign.Scorpio);
 //
 // await TaskExt.WhenAll(taurus, scorpio);
 // Console.WriteLine(taurus.Result);
 // Console.WriteLine(scorpio.Result);

//Stage 4
// var horo = new HoroService();
// var taurus = horo.MakeDailyHoroscopeBySign(HoroService.ZodiacSign.Taurus);
// var scorpio = horo.MakeDailyHoroscopeBySign(HoroService.ZodiacSign.Scorpio);
//  
// await (taurus, scorpio);
// Console.WriteLine(taurus.Result);
// Console.WriteLine(scorpio.Result);

//Stage 5
var horo = new HoroService();
var taurus = horo.MakeDailyHoroscopeBySign(HoroService.ZodiacSign.Taurus);
var scorpio = horo.MakeDailyHoroscopeBySign(HoroService.ZodiacSign.Scorpio);
 
var (forecast1, forecast2) = await (taurus, scorpio);
Console.WriteLine(forecast1);
Console.WriteLine(forecast2);


