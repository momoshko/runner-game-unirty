using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject[] obstacles; // ������ � �������������
    public Transform spawnPoint; // ����� ����������������
    public Transform startLocation; // ��������� �������

    private float spawnInterval = 3f; // �������� ����� ���������� �����������
    private float timer; // ������ ��� �������� ��������� ���������

    private void Start()
    {
        // ������������� ��������� ������� �����������
        spawnPoint.position = startLocation.position;
    }

    private void Update()
    {
        timer += Time.deltaTime;

        // ���� ������ ���������� �������, ���������� ����� �����������
        if (timer >= spawnInterval)
        {
            SpawnObstacle();
            timer = 0f;
        }
    }

    private void SpawnObstacle()
    {
        // �������� ��������� ����������� �� �������
        int randomIndex = Random.Range(0, obstacles.Length);
        GameObject obstacle = obstacles[randomIndex];

        // ������� ����� ��������� ����������� �� ����� ���������
        Instantiate(obstacle, spawnPoint.position, Quaternion.identity);
    }
}