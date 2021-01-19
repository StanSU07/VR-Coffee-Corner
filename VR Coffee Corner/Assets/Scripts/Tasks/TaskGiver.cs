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
    [SerializeField]
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

    public AudioSource[] voicelines;
    public AudioSource TaskDude;
    public Animator buttonAnim;

    private void Start()
    {
        taskWindow.SetActive(false);
    }

    private void Update()
    {

        //Testing-----------------------------------
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("added");
            System.Type type1 = System.Type.GetType("FlowersTask");
            Task1 = (Task)tasks.AddComponent(type1);
        }
        if (Input.GetKeyDown(KeyCode.Y)) { 
            System.Type type2 = System.Type.GetType("YogaTask");
            Task2 = (Task)tasks.AddComponent(type2);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("destroyed");

            Destroy(tasks.GetComponent("YogaTask"));
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            Destroy(tasks.GetComponent("FlowersTask"));
        }
        //--------------------------------------
    }

    public void Interact()
    {
        if (!AssignedTask){
            //assign
            AssignTask();
        }
        else
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


        TaskDude.clip = voicelines[1].clip;
        TaskDude.Play();
        Debug.Log(TaskDude.name.ToString());
       Debug.Log("3 tasks have been assigned");

        RandomTasks();
        
        System.Type type1 = System.Type.GetType(taskType1);
        Task1 = (Task)tasks.AddComponent(type1);

        System.Type type2 = System.Type.GetType(taskType2);
        Task2 = (Task)tasks.AddComponent(type2);

        System.Type type3 = System.Type.GetType(taskType3);
        Task3 = (Task)tasks.AddComponent(type3);


    }

    //checks if all tasks assigned have been completed
    //>If yes then give the reward for those tasks and remove tasks from the tasks gameobject
    void CheckTask()
    {
        if (Task1.Completed && Task2.Completed && Task3.Completed)
        {
            //give the reward to the player
            Task1.GiveReward();
            Task2.GiveReward();
            Task3.GiveReward();

            AssignedTask = false;
            taskWindow.SetActive(false);

            //reset the timers from zen garden
            Timer1.ResetTimer();
            Timer2.ResetTimer();
            stpwManager.resetStpwMethod();

            Debug.Log("You completed the tasks");
            TaskDude.clip = voicelines[3].clip;
            TaskDude.Play();

            //remove tasks
            Destroy(tasks.GetComponent(taskType1));
            Destroy(tasks.GetComponent(taskType2));
            Destroy(tasks.GetComponent(taskType3));

            buttonAnim.SetBool("isOpen", false);

        }
        else
        {
            Debug.Log("You still have tasks to complete");
            TaskDude.clip = voicelines[2].clip;
            TaskDude.Play();
            buttonAnim.SetBool("isOpen", false);

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






