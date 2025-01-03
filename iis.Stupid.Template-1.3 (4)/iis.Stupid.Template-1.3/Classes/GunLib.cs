using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.XR;
using Object = UnityEngine.Object;
using Input = ControllerInputPoller;
using BepInEx;
using GorillaLocomotion;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.Animations.Rigging;
using System.Collections;

namespace Hypnosis.Utilities
{
    internal class GunLib
    {
        public static GameObject Pointer = null;

        public static Material color = new Material(Shader.Find("GUI/Text Shader"));

        public static VRRig locked = null;

        public static bool button1 = ControllerInputPoller.instance.rightGrab;

        public static bool button2 = ControllerInputPoller.instance.rightControllerIndexFloat > 0;

        public static bool Locker = false;

        static bool computer = false;

        static Color Colorforgun = Color.red;

        public static RaycastHit Info;

        public static Camera Camera = GameObject.Find("Shoulder Camera").GetComponent<Camera>();
        public static (RaycastHit Info, bool button1) Gun()
        {
            if (button1 == UnityInput.Current.GetMouseButton(1))
            {
                Ray ray = (Camera != null) ? Camera.ScreenPointToRay(UnityInput.Current.mousePosition) : GorillaTagger.Instance.mainCamera.GetComponent<Camera>().ScreenPointToRay(UnityInput.Current.mousePosition);
                Physics.Raycast(ray.origin, ray.direction, out Info);
                computer = true;
            }
            else
            {
                Physics.Raycast(GorillaLocomotion.Player.Instance.rightControllerTransform.position - GorillaLocomotion.Player.Instance.rightControllerTransform.up, -GorillaLocomotion.Player.Instance.rightControllerTransform.up, out Info);
                computer = false;
            }
            color.color = Colorforgun;
            Pointer = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            Pointer.GetComponent<Renderer>().material.shader = Shader.Find("GUI/Text Shader");
            GameObject.Destroy(Pointer.GetComponent<SphereCollider>());
            GameObject.Destroy(Pointer.GetComponent<Rigidbody>());
            Pointer.GetComponent<Renderer>().material = color;
            Pointer.transform.localScale = new Vector3(0.14f, 0.14f, 0.14f);
            Pointer.transform.position = locked == null ? Info.point : locked.transform.position;
            UnityEngine.Object.Destroy(Pointer, Time.deltaTime);

            Vector3 vec3 = computer ? GorillaTagger.Instance.headCollider.transform.position : GorillaTagger.Instance.rightHandTransform.position;
            Vector3 PersonlockVector = locked == null ? Info.point : locked.transform.position;

            GameObject line = new GameObject("Line");
            LineRenderer liner = line.AddComponent<LineRenderer>();
            liner.material.shader = Shader.Find("GUI/Text Shader");
            liner.startColor = Colorforgun;
            liner.endColor = Colorforgun;
            liner.startWidth = 0.01f;
            liner.endWidth = 0.01f;
            liner.positionCount = 2;
            liner.useWorldSpace = true;
            liner.SetPosition(0, vec3);
            liner.SetPosition(1, PersonlockVector);
            UnityEngine.Object.Destroy(line, Time.deltaTime);
            return (Info, button1);
        }
        public static void Gunlib(Action action)
        {
            if ((ControllerInputPoller.instance.rightGrab || UnityInput.Current.GetMouseButton(1)))
            {
                if (UnityInput.Current.GetMouseButton(1))
                {
                    GunLib.button1 = UnityInput.Current.GetMouseButton(1);
                }
                else
                {
                    GunLib.button1 = ControllerInputPoller.instance.rightGrab;
                }

                var GunData = GunLib.Gun();

                bool Tigger = (ControllerInputPoller.instance.rightControllerIndexFloat > 0 || UnityInput.Current.GetMouseButton(0));

                if (Tigger && GunLib.locked != null)
                {
                    try
                    {
                        if (action != null)
                        {
                            action();
                            Colorforgun = Color.cyan;
                        }
                    } catch { }
                }
                else
                {
                    Colorforgun = Color.red;
                }
                if (Tigger)
                {
                    if (GunLib.Info.collider.GetComponentInParent<VRRig>() && GunLib.Info.collider.GetComponentInParent<VRRig>() != GorillaTagger.Instance.offlineVRRig)
                    {
                        GunLib.locked = GunLib.Info.collider.GetComponentInParent<VRRig>();
                    }
                }
                if (GunLib.Info.collider.GetComponentInParent<VRRig>() && GunLib.Info.collider.GetComponentInParent<VRRig>() != GorillaTagger.Instance.offlineVRRig && !Tigger)
                {
                    Colorforgun = Color.green;
                    GorillaTagger.Instance.StartVibration(false, 1f, Time.deltaTime);
                }
            }
            else
            {
                UnityEngine.Object.Destroy(GunLib.Pointer);
                GorillaTagger.Instance.offlineVRRig.enabled = true;
                GunLib.locked = null;
                GunLib.Pointer = null;
            }
        }
        public static void GunlibNotLocked(Action action)
        {
            if ((ControllerInputPoller.instance.rightGrab || UnityInput.Current.GetMouseButton(1)))
            {
                if (UnityInput.Current.GetMouseButton(1))
                {
                    GunLib.button1 = UnityInput.Current.GetMouseButton(1);
                }
                else
                {
                    GunLib.button1 = ControllerInputPoller.instance.rightGrab;
                }

                var GunData = GunLib.Gun();

                if (ControllerInputPoller.instance.rightControllerIndexFloat > 0 || UnityInput.Current.GetMouseButton(0))
                {
                    try
                    {
                        if (action != null)
                        {
                            action();
                            Colorforgun = Color.green;
                        }
                    }
                    catch { }
                }
                else
                {
                    Colorforgun = Color.red;
                }
            }
            else
            {
                UnityEngine.Object.Destroy(GunLib.Pointer);
                GorillaTagger.Instance.offlineVRRig.enabled = true;
                GunLib.locked = null;
                GunLib.Pointer = null;
            }
        }
    }
}
