using System;

namespace DependencyInversionPrinciple
{
    public class Research
    {
        public Research(IRelationshipBrowser browser)
        {
            foreach (var p in browser.FindAllChildrenOf("John"))
                Console.WriteLine($"John has a child called {p.Name}");
        }
    }
}