using UnityEngine;

// Very not efficient, could not bother thinking any other way.
public class MapInformation : MonoBehaviour
{
    [SerializeField]
    GameObject[] panels;

    public void MainHallIn()
    {
        panels[0].SetActive(true);
    }

    public void MainHallOut()
    {
        panels[0].SetActive(false);
    }

    public void ThroneRoomIn()
    {
        panels[1].SetActive(true);
    }

    public void ThroneRoomOut()
    {
        panels[1].SetActive(false);
    }

    public void LordRoomIn()
    {
        panels[2].SetActive(true);
    }

    public void LordRoomOut()
    {
        panels[2].SetActive(false);
    }

    public void DiningHallIn()
    {
        panels[3].SetActive(true);
    }

    public void DiningHallOut()
    {
        panels[3].SetActive(false);
    }

    public void KitchenIn()
    {
        panels[4].SetActive(true);
    }

    public void KitchenOut()
    {
        panels[4].SetActive(false);
    }

    public void MainCorridorIn()
    {
        panels[5].SetActive(true);
    }

    public void MainCorridorOut()
    {
        panels[5].SetActive(false);
    }

    public void GuestRoom1In()
    {
        panels[6].SetActive(true);
    }

    public void GuestRoom1Out()
    {
        panels[6].SetActive(false);
    }

    public void GuestRoom2In()
    {
        panels[7].SetActive(true);
    }

    public void GuestRoom2Out()
    {
        panels[7].SetActive(false);
    }

    public void GuestRoom3In()
    {
        panels[8].SetActive(true);
    }

    public void GuestRoom3Out()
    {
        panels[8].SetActive(false);
    }

    public void ServantRoom1In()
    {
        panels[9].SetActive(true);
    }

    public void ServantRoom1Out()
    {
        panels[9].SetActive(false);
    }

    public void ServantRoom2In()
    {
        panels[10].SetActive(true);
    }

    public void ServantRoom2Out()
    {
        panels[10].SetActive(false);
    }

    public void ServantRoom3In()
    {
        panels[11].SetActive(true);
    }

    public void ServantRoom3Out()
    {
        panels[11].SetActive(false);
    }

    public void ChefRoomIn()
    {
        panels[12].SetActive(true);
    }

    public void ChefRoomOut()
    {
        panels[12].SetActive(false);
    }

    public void KeeperRoomIn()
    {
        panels[13].SetActive(true);
    }

    public void KeeperRoomOut()
    {
        panels[13].SetActive(false);
    }

    public void ChamberIn()
    {
        panels[14].SetActive(true);
    }

    public void ChamberOut()
    {
        panels[14].SetActive(false);
    }

    public void StorageIn()
    {
        panels[15].SetActive(true);
    }

    public void StorageOut()
    {
        panels[15].SetActive(false);
    }
}
