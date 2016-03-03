    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Enums
{
    public enum HistoryEventType
    {
        TaskCreated,
        TaskEdited,
        TaskRemoved,
        TaskFinished,

        WorkStarted,
        WorkStopped,

        ExperienceGained,
        LevelGained,

        SkillExperienceGained,
        SkillLevelGained,
        SkillCreated,
        SkillRemoved,
        SkillEdited,

        ProfileCreated,
        ProfileEdited,
        ProfileRemoved,
        
        DaySaved,
        DayUpdated
    }
}
