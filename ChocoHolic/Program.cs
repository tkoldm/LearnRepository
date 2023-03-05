using ChocoHolic;

var tasks = new []
{
    Task.Factory.StartNew(() =>
    {
        var boiler = ChocolateBoiler.GetInstance();
        boiler.Fill();
        boiler.Boil();
        boiler.Drain();
    }),
    Task.Factory.StartNew(() =>
    {
        var boiler = ChocolateBoiler.GetInstance();
        boiler.Fill();
        boiler.Boil();
        boiler.Drain();
    })
};

await Task.WhenAll(tasks);