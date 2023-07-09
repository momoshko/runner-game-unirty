using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject[] obstacles; // Массив с препятствиями
    public Transform spawnPoint; // Место появленияятствий
    public Transform startLocation; // Стартовая локация

    private float spawnInterval = 3f; // Интервал между генерацией препятствий
    private float timer; // Таймер для контроля интервала генерации

    private void Start()
    {
        // Устанавливаем начальную позицию спаунпоинта
        spawnPoint.position = startLocation.position;
    }

    private void Update()
    {
        timer += Time.deltaTime;

        // Если прошло достаточно времени, генерируем новое препятствие
        if (timer >= spawnInterval)
        {
            SpawnObstacle();
            timer = 0f;
        }
    }

    private void SpawnObstacle()
    {
        // Выбираем случайное препятствие из массива
        int randomIndex = Random.Range(0, obstacles.Length);
        GameObject obstacle = obstacles[randomIndex];

        // Создаем новый экземпляр препятствия на месте появления
        Instantiate(obstacle, spawnPoint.position, Quaternion.identity);
    }
}