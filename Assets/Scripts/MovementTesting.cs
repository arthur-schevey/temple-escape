using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Hands;
using UnityEngine.XR.Management;

public class MovementTesting : MonoBehaviour
{
    public XRHand hand;
    public GameObject displayTransform;

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
        JointData();
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

    void JointData()
    {
        for (var i = XRHandJointID.BeginMarker.ToIndex();
        i < XRHandJointID.EndMarker.ToIndex();
        i++)
        {
            var trackingData = hand.GetJoint(XRHandJointIDUtility.FromIndex(i));

            if (trackingData.TryGetPose(out Pose pose))
            {
                // displayTransform is some GameObject's Transform component
                displayTransform.transform.localPosition = pose.position;
                displayTransform.transform.localRotation = pose.rotation;
            }
            else {
                Debug.Log("somethings wrong");
            }
        }
    }


}
