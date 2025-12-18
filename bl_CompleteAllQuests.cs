using Den.Tools;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.VolumeComponent;

namespace BitchLand//must have this namespace
{
	class bl_CompleteAllQuestsModDoWork 
	{
		public bl_CompleteAllQuestsModDoWork() 
		{ 
		}
		
		public void OnEnable()
		{
			doWork();
		}

        public void OnDisable()
        {

        }

        public void doWork()
		{
			int allMissionsCount = Main.Instance.AllMissions.Count;
            for (int index1 = 0; index1 < allMissionsCount; ++index1)
            {
                if (!Main.Instance.AllMissions[index1].CurrentGoal.isNull())
                {
                    Main.Instance.AllMissions[index1].CurrentGoal.Completed = true;
                    Main.Instance.AllMissions[index1].CurrentGoal.Failed = false;
                    string completeQuestString = "bl_CompleteAllQuestsModDoWork.doWork() Complete quest: " + Main.Instance.AllMissions[index1].CurrentGoal.ToString();
                    Main.Instance.GameplayMenu.ShowNotification(completeQuestString);
                    Debug.Log((object)completeQuestString);
                }

				int goalsCount = Main.Instance.AllMissions[index1].Goals.Count;
                for (int index2 = 0; index2 < goalsCount; ++index2)
                {
                    if (!Main.Instance.AllMissions[index1].Goals[index2].isNull())
                    {
                        Main.Instance.AllMissions[index1].Goals[index2].Completed = true;
                        Main.Instance.AllMissions[index1].Goals[index2].Failed = false;
                        string completeQuestString = "bl_CompleteAllQuestsModDoWork.doWork() Complete quest: " + Main.Instance.AllMissions[index1].Goals[index2].ToString();
                        Main.Instance.GameplayMenu.ShowNotification(completeQuestString);
                        Debug.Log((object)completeQuestString);
                    }
                }
            }
			allMissionsCount = Main.Instance.GameplayMenu.CurrentMissions.Count;
            for (int index3 = 0; index3 < allMissionsCount; ++index3)
            {
                if (!Main.Instance.GameplayMenu.CurrentMissions[index3].CurrentGoal.isNull())
                {
                    Main.Instance.GameplayMenu.CurrentMissions[index3].CurrentGoal.Completed = true;
                    Main.Instance.GameplayMenu.CurrentMissions[index3].CurrentGoal.Failed = false;
                    string completeQuestString = "bl_CompleteAllQuestsModDoWork.doWork() Complete quest: " + Main.Instance.GameplayMenu.CurrentMissions[index3].CurrentGoal.ToString();
                    Main.Instance.GameplayMenu.ShowNotification(completeQuestString);
                    Debug.Log((object)completeQuestString);
                }
                int goalsCount = Main.Instance.GameplayMenu.CurrentMissions[index3].Goals.Count;
                for (int index4 = 0; index4 < goalsCount; ++index4)
                {
                    if (!Main.Instance.GameplayMenu.CurrentMissions[index3].Goals[index4].isNull())
                    {
                        Main.Instance.GameplayMenu.CurrentMissions[index3].Goals[index4].Completed = true;
                        Main.Instance.GameplayMenu.CurrentMissions[index3].Goals[index4].Failed = false;
                        string completeQuestString = "bl_CompleteAllQuestsModDoWork.doWork() Complete quest: " + Main.Instance.GameplayMenu.CurrentMissions[index3].Goals[index4].ToString();
                        Main.Instance.GameplayMenu.ShowNotification(completeQuestString);
                        Debug.Log((object)completeQuestString);
                    }
                }
            }
            if (!Main.Instance.GameplayMenu.CurrentMission.IsNull())
            {
                if (!Main.Instance.GameplayMenu.CurrentMission.CurrentGoal.isNull())
                {
                    Main.Instance.GameplayMenu.CurrentMission.CurrentGoal.Completed = true;
                    Main.Instance.GameplayMenu.CurrentMission.CurrentGoal.Failed = false;
                    string completeQuestString = "bl_CompleteAllQuestsModDoWork.doWork() Complete quest: " + Main.Instance.GameplayMenu.CurrentMission.CurrentGoal.ToString();
                    Main.Instance.GameplayMenu.ShowNotification(completeQuestString);
                    Debug.Log((object)completeQuestString);
                }
                int goalsCount = Main.Instance.GameplayMenu.CurrentMission.Goals.Count;
                for (int index = 0; index < goalsCount; ++index)
                {
                    if (!Main.Instance.GameplayMenu.CurrentMission.Goals[index].isNull())
                    {
                        Main.Instance.GameplayMenu.CurrentMission.Goals[index].Completed = true;
                        Main.Instance.GameplayMenu.CurrentMission.Goals[index].Failed = false;
                        string completeQuestString = "bl_CompleteAllQuestsModDoWork.doWork() Complete quest: " + Main.Instance.GameplayMenu.CurrentMission.Goals[index].ToString();
                        Main.Instance.GameplayMenu.ShowNotification(completeQuestString);
                        Debug.Log((object)completeQuestString);
                    }
                }
            }
            string completeQuestString2 = "bl_CompleteAllQuestsModDoWork.doWork() Complete All Quests";
            Main.Instance.GameplayMenu.ShowNotification(completeQuestString2);
            Debug.Log((object)completeQuestString2);
        }

		public static bl_CompleteAllQuestsModDoWork Instance = new bl_CompleteAllQuestsModDoWork();
    }

	public class Mod//must have this class name
	{
		public static bl_CompleteAllQuestsMod ThisMod;

		public static void Init() //must have this name, and MUST be static
		{
			ThisMod = Main.Instance.gameObject.AddComponent<bl_CompleteAllQuestsMod>();
		}



		public static void EnableMod(bool value)
		{
			if(value)
			{//mod was enabled in the settings
				bl_CompleteAllQuestsModDoWork.Instance.OnEnable();
            }
			else
			{
				bl_CompleteAllQuestsModDoWork.Instance.OnDisable();
			}
		}
	}

	public class bl_CompleteAllQuestsMod : MonoBehaviour
	{
		public void Start()
		{
            bl_CompleteAllQuestsModDoWork.Instance.OnEnable();
        }

	}
}

