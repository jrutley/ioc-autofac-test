# Autofac demo

This is for my co-workers to see that Autofac can live in harmony with the MS DI implementation. This is in light of the article 
https://josefottosson.se/you-are-probably-still-using-httpclient-wrong-and-it-is-destabilizing-your-software/ and the need to refactor a number of HttpClient calls that are using "using"

As a disclaimer, this was whipped up in 5 minutes, so please excuse the terrible naming and service behaviours

## Steps

### DI Fail

Comment out the Startup::ConfigureContainer method and "services.AddTransient<OtherService>();"  
Notice that you get an exception saying the OtherService couldn't be found.

### Loading OtherService with MS DI

Comment out the Startup::ConfigureContainer method and uncomment "services.AddTransient<OtherService>();"  

Run and enjoy Google's homepage in its texty glory

### Loading OtherService directly

Comment out "services.AddTransient<OtherService>();"  
Uncomment the ConfigureContainer method and uncomment "builder.RegisterType<OtherService>().AsSelf();"  
Comment out the RegisterModule method

Run and enjoy!

### Loading OtherService via a module

Comment out "services.AddTransient<OtherService>();" and "builder.RegisterType<OtherService>().AsSelf();"  
Uncomment the RegisterModule method call

Run and enjoy!