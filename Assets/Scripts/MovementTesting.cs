using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Hands;
using UnityEngine.XR.Management;

public class MovementTesting : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        XRHandSubsystem m_Subsystem =
        XRGeneralSettings.Instance?
            .Manager?
            .activeLoader?
            .GetLoadedSubsystem<XRHandSubsystem>();

        if (m_Subsystem != null)
            m_Subsystem.updatedHands += OnHandUpdate;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnHandUpdate(XRHandSubsystem subsystem,
                  XRHandSubsystem.UpdateSuccessFlags updateSuccessFlags,
                  XRHandSubsystem.UpdateType updateType)
    {
        switch (updateType)
        {
            case XRHandSubsystem.UpdateType.Dynamic:
                // Update game logic that uses hand data
                break;
            case XRHandSubsystem.UpdateType.BeforeRender:
                // Update visual objects that use hand data
                break;
        }
    }


}
