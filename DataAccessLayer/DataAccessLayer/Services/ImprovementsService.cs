using System;
using System.Text;
using DataAccessLayer.Repositories;
using DataAccessLayer.Repositories.Interfaces;
using DataAccessLayer.Services.Interfaces;
using Model.Entities;
using Model.Enums;

namespace DataAccessLayer.Services
{
    public class ImprovementsService : IImprovementsService
    {
        private IImprovementsRepository improvementsRepository;
        private IProfileRepository profileRepository;
        private ITasksRepository tasksRepository;
        private readonly ISkillsRepository skillsRepository;
        private IHistoryService historyService;

        public ImprovementsService(IImprovementsRepository daysRepository, IProfileRepository profileRepository,
            IHistoryService historyService, ITasksRepository tasksRepository, ISkillsRepository skillsRepository)
        {
            this.improvementsRepository = daysRepository;
            this.profileRepository = profileRepository;
            this.historyService = historyService;
            this.tasksRepository = tasksRepository;
            this.skillsRepository = skillsRepository;
        }


        public Improvement CreateNewImprovement(int? ownerId, ImprovementType type, ImprovementOrigin origin, int amount,
            int? associatedEntityId = null, int? associatedSkillId = null)
        {
            Improvement improvement = new Improvement();
            improvement.Type = type;
            improvement.Origin = origin;
            improvement.Amount = amount;
            improvement.Occured = DateTime.Now;

            if (ownerId.HasValue)
            {
                improvement.Owner = profileRepository.Get(ownerId.Value);
            }

            if (associatedEntityId.HasValue)
            {
                improvement.AssociatedEntityId = associatedEntityId.Value;
            }

            if (associatedSkillId.HasValue)
            {
                improvement.AssociatedSkill = skillsRepository.Get(associatedSkillId.Value);
            }

            return improvement;
        }

        public void SaveImprovement(Improvement improvementToSave)
        {
            improvementsRepository.Add(improvementToSave);
        }

        public string GetImprovementDescription(Improvement improvement)
        {
            StringBuilder description = new StringBuilder();
            
            switch (improvement.Type)
            {
                case ImprovementType.ExperienceGained:
                    description.AppendFormat("+{0} XP for ", improvement.Amount);
                    break;

                case ImprovementType.SkillExperienceGained:
                    description.AppendFormat("{0} +{1} XP for", improvement.AssociatedSkill.Name, improvement.Amount);
                    break;

                case ImprovementType.LevelUp:
                    description.AppendFormat("You reached {0} level", improvement.Amount);
                    break;

                case ImprovementType.SkillLevelUp:
                    description.AppendFormat("Your skill {0} reached {1} level", improvement.AssociatedSkill.Name, improvement.Amount);
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }

            switch (improvement.Origin)
            {
                case ImprovementOrigin.TaskCreation:
                    if (improvement.AssociatedEntityId.HasValue)
                    {
                        Task createdTask = tasksRepository.Get(improvement.AssociatedEntityId.Value);

                        if (createdTask != null)
                            description.AppendFormat(" creating task '{0}'.", createdTask.Name);
                        else
                            description.Append("creating task.");
                    }
                    break;

                case ImprovementOrigin.TaskCompletion:
                    if (improvement.AssociatedEntityId.HasValue)
                    {
                        Task createdTask = tasksRepository.Get(improvement.AssociatedEntityId.Value);

                        if (createdTask != null)
                            description.AppendFormat(" completing task '{0}'.", createdTask.Name);
                        else
                            description.Append("completing task.");
                    }
                    break;

                case ImprovementOrigin.DiaryUpdate:
                    description.AppendFormat(" updating diary.");
                    break;
            
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return description.ToString();
        }
    }
}
