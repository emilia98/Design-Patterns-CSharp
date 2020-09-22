using DocumentsCreator.ConcreteProduct;
using DocumentsCreator.Creator;

namespace DocumentsCreator.ConcreteCreator
{
    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    public class Resume : Document
    {
        // Factory Method Implementation
        public override void CreatePages()
        {
            Pages.Add(new SkillsPage());
            Pages.Add(new EducationPage());
            Pages.Add(new ExperiencePage());
        }
    }
}
