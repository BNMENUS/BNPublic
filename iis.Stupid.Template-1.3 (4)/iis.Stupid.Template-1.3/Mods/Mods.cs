using BepInEx;
using Microsoft.Cci;
using ModIO;
using Photon.Pun;
using Photon.Realtime;
using StupidTemplate.Menu;
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

        public static void NormalArms()
        {
            GorillaLocomotion.Player.Instance.transform.localScale = new Vector3(1f, 1f, 1f);
        }
        public static void GhostMonkey()
        {
            if (ControllerInputPoller.instance.rightControllerSecondaryButton)
            {
                GorillaTagger.Instance.offlineVRRig.enabled = !GorillaTagger.Instance.offlineVRRig.enabled;
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


        public static Material PlatColor = new Material(Shader.Find("GorillaTag/UberShader"));
        public static GameObject LeftPlat;
        public static GameObject RightPlat;
        static bool rightdone = false;
        static bool leftdone = false;

        public static void Platforms()
        {
            if (ControllerInputPoller.instance.rightGrab && !rightdone)
            {
                RightPlat = GameObject.CreatePrimitive(PrimitiveType.Cube);
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
                LeftPlat = GameObject.CreatePrimitive(PrimitiveType.Cube);
                LeftPlat.transform.position = new Vector3(0f, -0.05f, 0f) +
            GorillaLocomotion.Player.Instance.leftControllerTransform.position;
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

        public static void Noclip()
        {
            foreach (MeshCollider meshCollider in Resources.FindObjectsOfTypeAll<MeshCollider>())
            {
                if (ControllerInputPoller.instance.leftControllerIndexFloat > 0f || UnityInput.Current.GetMouseButton(1))
                {
                    meshCollider.enabled = false;
                }
                else
                {
                    meshCollider.enabled = true;
                }
            }
        }

        public static void AntiReport()
        {
            foreach (GorillaPlayerScoreboardLine line in GorillaScoreboardTotalUpdater.allScoreboardLines)
            {
                Transform report = line.reportButton.gameObject.transform;
                foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
                {
                    float righthand = Vector3.Distance(vrrig.rightHandTransform.position, report.position);
                    float lefthand = Vector3.Distance(vrrig.leftHandTransform.position, report.position);

                    if (righthand >= 0.3f || lefthand >= 0.3f)
                    {
                        PhotonNetwork.Disconnect();
                    }
                }
            }
        }
        public static int disconnectbutton;
        public static void changedisconnectbutton()
        {
            if (disconnectbutton <= 16) disconnectbutton++;
            if (disconnectbutton >= 16) disconnectbutton = 0;
        }
        public static string disconnectbuttonstring = "";
        public static void DisconnectOnButton()
        {
            switch (disconnectbutton)
            {
                case 0:
                    {
                        if (ControllerInputPoller.instance.rightControllerSecondaryButton)
                        {
                            PhotonNetwork.Disconnect();
                            disconnectbuttonstring = "Disconnect Button {Right Secondary}";
                        }
                        break;
                    }
                case 1:
                    {
                        if (ControllerInputPoller.instance.rightControllerPrimaryButton)
                        {
                            PhotonNetwork.Disconnect();
                            disconnectbuttonstring = "Disconnect Button {Right Primary}";
                        }
                        break;
                    }
                case 2:
                    {
                        if (ControllerInputPoller.instance.leftControllerSecondaryButton)
                        {
                            PhotonNetwork.Disconnect();
                            disconnectbuttonstring = "Disconnect Button {Left Secondary}";
                        }
                        break;
                    }
                case 3:
                    {
                        if (ControllerInputPoller.instance.leftControllerPrimaryButton)
                        {
                            PhotonNetwork.Disconnect();
                            disconnectbuttonstring = "Disconnect Button {Left Primary}";
                        }
                        break;
                    }
                case 4:
                    {
                        if (ControllerInputPoller.instance.rightControllerIndexFloat <= 0.1f)
                        {
                            PhotonNetwork.Disconnect();
                            disconnectbuttonstring = "Disconnect Button {Right Trigger}";
                        }
                        break;
                    }
                case 5:
                    {
                        if (ControllerInputPoller.instance.rightGrab)
                        {
                            PhotonNetwork.Disconnect();
                            disconnectbuttonstring = "Disconnect Button {Right Grab}";
                        }
                        break;
                    }
                case 6:
                    {
                        if (ControllerInputPoller.instance.leftControllerIndexFloat <= 0.1f)
                        {
                            PhotonNetwork.Disconnect();
                            disconnectbuttonstring = "Disconnect Button {Left Trigger}";
                        }
                        break;
                    }
                case 7:
                    {
                        if (ControllerInputPoller.instance.leftGrab)
                        {
                            PhotonNetwork.Disconnect();
                            disconnectbuttonstring = "Disconnect Button {Left Grab}";
                        }
                        break;
                    }
            }
            Main.GetIndex("Disconnect Button").overlapText = disconnectbuttonstring;
        }


    }
}
