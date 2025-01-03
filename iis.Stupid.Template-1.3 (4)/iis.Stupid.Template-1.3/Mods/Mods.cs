﻿using Photon.Pun;
using Photon.Realtime;
using StupidTemplate.Notifications;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.XR;


namespace StupidTemplate.Mods
{
    internal class Mods
    {
        public static void MosaSpeed()
        {
            GorillaLocomotion.Player.Instance.maxJumpSpeed = 7.5f;
            GorillaLocomotion.Player.Instance.jumpMultiplier = 3.5f;
        }

        public static void LongArms()
        {
            GorillaLocomotion.Player.Instance.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
        }

        public static void ReallyLongArms()
        {
            GorillaLocomotion.Player.Instance.transform.localScale = new Vector3(2f, 2f, 2f);
        }

        public static void GhostMonkey()
        {
            if (ControllerInputPoller.instance.rightControllerSecondaryButton)
            {
                GorillaTagger.Instance.offlineVRRig.enabled = ! GorillaTagger.Instance.offlineVRRig.enabled;
            }
        }

        public static void Wallwalk()
        {
            bool flag = ControllerInputPoller.GripFloat((XRNode)5) == 1f;
            if (flag)
            {
                GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.velocity += GorillaLocomotion.Player.Instance.bodyCollider.transform.right / 7f;
            }
            bool flag2 = ControllerInputPoller.GripFloat((XRNode)4) == 1f;
            if (flag2)
            {
                GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.velocity += -GorillaLocomotion.Player.Instance.bodyCollider.transform.right / 7f;
            }
        }

        public static void SpazMonke()
        {
            {
                GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)UnityEngine.Random.Range(0, 360), (float)UnityEngine.Random.Range(0, 360), (float)UnityEngine.Random.Range(0, 360));
                GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)UnityEngine.Random.Range(0, 360), (float)UnityEngine.Random.Range(0, 360), (float)UnityEngine.Random.Range(0, 360));
                GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)UnityEngine.Random.Range(0, 360), (float)UnityEngine.Random.Range(0, 360), (float)UnityEngine.Random.Range(0, 360));
                GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)UnityEngine.Random.Range(0, 360), (float)UnityEngine.Random.Range(0, 180), (float)UnityEngine.Random.Range(0, 180));
                GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)UnityEngine.Random.Range(0, 360), (float)UnityEngine.Random.Range(0, 180), (float)UnityEngine.Random.Range(0, 180));
                GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)UnityEngine.Random.Range(0, 360), (float)UnityEngine.Random.Range(0, 180), (float)UnityEngine.Random.Range(0, 180));
            }
        }
        public static void FlyMod()
        {
            if (ControllerInputPoller.instance.rightControllerPrimaryButton)
            {
               GorillaLocomotion.Player.Instance.transform.position += (GorillaLocomotion.Player.Instance.headCollider.transform.forward * Time.deltaTime) * 15;
               GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
            }
        }

        public static void DisplayBoxESP()
        {
            foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
            {
                if (vrrig != GorillaTagger.Instance.offlineVRRig)
                {
                    UnityEngine.Color thecolor = vrrig.playerColor;
                    GameObject box = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    box.transform.position = vrrig.transform.position;
                    UnityEngine.Object.Destroy(box.GetComponent<BoxCollider>());
                    box.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                    box.transform.LookAt(GorillaTagger.Instance.headCollider.transform.position);
                    box.GetComponent<Renderer>().material.shader = Shader.Find("GUI/Text Shader");
                    box.GetComponent<Renderer>().material.color = thecolor;
                    UnityEngine.Object.Destroy(box, 0.1f); // Destroy after a short delay
                }
            }
        }

        static bool rightdone = false;
        static bool leftdone = false;

        public static void Platforms()
        {
            if (ControllerInputPoller.instance.rightGrab && !rightdone)
            {
                GameObject RightPlat = GameObject.CreatePrimitive(PrimitiveType.Cube);
                RightPlat.transform.position = new Vector3(0f, -0.05f, 0f) + GorillaLocomotion.Player.Instance.rightControllerTransform.position;
                RightPlat.transform.rotation = GorillaLocomotion.Player.Instance.rightControllerTransform.rotation;
                PlatColor.color = UnityEngine.Color.black;
                RightPlat.GetComponent<Renderer>().material.shader = Shader.Find("GUI/Text Shader");
                RightPlat.GetComponent<Renderer>().material = PlatColor;
                RightPlat.transform.localScale = new Vector3(0.01f, 0.23f, 0.362569f);
                rightdone = true;
            }
            else
            {
                UnityEngine.Object.Destroy(RightPlat);
                rightdone = false;
            }
            if (ControllerInputPoller.instance.leftGrab && !leftdone)
            {
                GameObject LeftPlat = GameObject.CreatePrimitive(PrimitiveType.Cube);
                LeftPlat.transform.position = new Vector3(0f, -0.05f, 0f) + GorillaLocomotion.Player.Instance.leftControllerTransform.position;
                LeftPlat.transform.rotation = GorillaLocomotion.Player.Instance.leftControllerTransform.rotation;
                PlatColor.color = UnityEngine.Color.black;
                LeftPlat.GetComponent<Renderer>().material.shader = Shader.Find("GUI/Text Shader");
                LeftPlat.GetComponent<Renderer>().material = PlatColor;
                LeftPlat.transform.localScale = new Vector3(0.01f, 0.23f, 0.362569f);
                leftdone = true;
            }
            else
            {
                UnityEngine.Object.Destroy(LeftPlat);
                leftdone = false;
            }
        }

        public static void FixSpeed()
        {
            GorillaLocomotion.Player.Instance.maxJumpSpeed = 6.5f;
            GorillaLocomotion.Player.Instance.jumpMultiplier = 1.2f;
        }

    }
}
