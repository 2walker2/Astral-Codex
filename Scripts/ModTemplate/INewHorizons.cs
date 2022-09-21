using OWML.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.Events;
using UnityEngine;

public interface INewHorizons
{
    void LoadConfigs(IModBehaviour mod);

    GameObject GetPlanet(string name);

    string GetCurrentStarSystem();

    UnityEvent<string> GetChangeStarSystemEvent();

    UnityEvent<string> GetStarSystemLoadedEvent();

    GameObject SpawnObject(GameObject planet, Sector sector, string propToCopyPath, Vector3 position, Vector3 eulerAngles, float scale, bool alignWithNormal);

    string[] GetInstalledAddons();
}
