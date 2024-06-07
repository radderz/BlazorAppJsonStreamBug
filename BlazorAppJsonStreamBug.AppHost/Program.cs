var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.BlazorAppJsonStreamBug>("blazorapp-jsonstreambug");

builder.Build().Run();
