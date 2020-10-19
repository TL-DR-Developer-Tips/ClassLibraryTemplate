using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Randomizers;
using System;

namespace TLDR.ClassLibraryTemplate
{
    public class HelloWorld
    {
        public string Greeting(string personToGreet)
        {
            if (string.IsNullOrEmpty(personToGreet))
            {
                throw new ArgumentException("message", nameof(personToGreet));
            }
            return $"{personToGreet}, hello world.";
        }

        public string WhoDis()
        {
            var randomName =   RandomizerFactory.GetRandomizer(new FieldOptionsFirstName());
            return $"{randomName.Generate()}";             
        }

    }
}
