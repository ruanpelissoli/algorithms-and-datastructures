// See https://aka.ms/new-console-template for more information
using AlgorithmsAndDataStructures;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System.Reflection;

var serviceCollection = new ServiceCollection();

var assemblies = new Assembly[] { typeof(Program).Assembly };
var typesFromAssemblies = assemblies.SelectMany(a =>
    a.DefinedTypes.Where(x => x.GetInterfaces().Contains(typeof(IAlgorithmSolver))));

foreach (var type in typesFromAssemblies)
{
    serviceCollection.Add(new ServiceDescriptor(typeof(IAlgorithmSolver), type, ServiceLifetime.Transient));
}

var builder = serviceCollection.BuildServiceProvider();

var altorithmSolverImplementations = Assembly.GetExecutingAssembly()
    .GetTypes()
    .Where(type => typeof(IAlgorithmSolver).IsAssignableFrom(type) && !type.IsInterface);

foreach (var type in altorithmSolverImplementations)
{
    if (Activator.CreateInstance(type) is not IAlgorithmSolver instance)
        continue;

    instance.Solve();
}