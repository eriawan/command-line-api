using System.Collections.Generic;
using System.IO;

namespace System.CommandLine.CompletionSuggestions
{
    public interface ISuggestionRegistration
    {
        void AddSuggestionRegistration(SuggestionRegistration registration);
        SuggestionRegistration FindRegistration(FileInfo soughtExecutable);
        IReadOnlyCollection<SuggestionRegistration> FindAllRegistrations();
    }
}