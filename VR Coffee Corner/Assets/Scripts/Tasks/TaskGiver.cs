using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskGiver : MonoBehaviour
{
    public bool AssignedTask { get; set; }

    [SerializeField]
    private GameObject tasks;
    [SerializeField]
    private List<string> taskList; //add all task scripts name

    [SerializeField]
    private GameObject taskWindow;
    private Stopwatch_Manager stpwManager;

    //the 3 given tasks
    [SerializeField]
    private string taskType1;
    [SerializeField]
    private string taskType2;
    [SerializeField]
    private string taskType3;

    public Task Task1 { get; set; }
    public Task Task2 { get; set; }
    public Task Task3 { get; set; }



    private void Start()
    {
        stpwManager = GameObject.Find("Stopwatch_Manager").GetComponent<Stopwatch_Manager>();
        taskWindow.SetActive(false);
    }

    public void Interact()
    {
        if (!AssignedTask){
            //assign
            AssignTask();
        }
        else if (AssignedTask)
        {
            //check
            CheckTask();
        }
    }

    //add the 3 task types to the tasks game object
    public void AssignTask()
    {
        AssignedTask = true;
        taskWindow.SetActive(true); 
        


       Debug.Log("3 tasks have been assigned");

        RandomTasks();
        
        System.Type type1 = System.Type.GetType(taskType1);
        Task1 = (Task)tasks.AddComponent(type1);

        System.Type type2 = System.Type.GetType(taskType2);
        Task2 = (Task)tasks.AddComponent(type2);

        System.Type type3 = System.Type.GetType(taskType3);
        Task3 = (Task)tasks.AddComponent(type3);


    }

    void CheckTask()
    {

        //get a task reference
       // Task1 = GameObject.Find("Tasks").GetComponent<YogaTask>();
        if (Task1.Completed && Task2.Completed && Task3.Completed)
        {
            Task1.GiveReward();
            Task2.GiveReward();
            Task3.GiveReward();

            AssignedTask = false;
            taskWindow.SetActive(false);

            Timer1.ResetTimer();
            Timer2.ResetTimer();
            stpwManager.resetStpwMethod();

            Debug.Log("You completed the tasks");
        }
        else
        {
            Debug.Log("You still have tasks to complete");
        }
    }

    //Summary
    //make another list which is going to copy the same component that are in the taskList
    //so whenever a random task is being assigned the task is removed from the new list so no double tasks can happen
    void RandomTasks() 
    {

        List<string> taskPicker = new List<string>(taskList);

        taskType1 = taskPicker[Random.Range(0, taskPicker.Count)];
        taskPicker.Remove(taskType1);
        taskType2 = taskPicker[Random.Range(0, taskPicker.Count)];
        taskPicker.Remove(taskType2);
        taskType3 = taskPicker[Random.Range(0, taskPicker.Count)];
        taskPicker.Remove(taskType3);
        
    }

         //   PlacesEvent.current.PlaceTaskActivate(id);

}
/*    public List<Task> tasks = new List<Task>();

    public Task task;

    public Player player;

    public GameObject taskWindow;
    public Text descriptionText;
    public Text restPointsText;
    public Text energyPointsText;

    public void OpenTaskWindow()
    {
        if (!taskWindow.activeSelf) { taskWindow.SetActive(true); }
        else if (taskWindow.activeSelf) { taskWindow.SetActive(false); }


        descriptionText.text = task.description;
        restPointsText.text = task.restPointsReward.ToString();
    }

*//*    public void AcceptTasks()
    {
        taskWindow.SetActive(false);
        task.isActive = true;

        player.task.Add("task");
        player.task = task;
    }

*/






