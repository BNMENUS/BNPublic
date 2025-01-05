@ -120,147 + 120,147 @@
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
public static int disconnectbutton = 0;
public static void changedisconnectbutton()
{
    Main.GetIndex("Disconnect Button").overlapText = disconnectbuttonstring;

    if (disconnectbutton <= 9) { disconnectbutton++; }

    if (disconnectbutton >= 9) { disconnectbutton = 0; }

    switch (disconnectbutton)
    {
        case 0:
            {
                disconnectbuttonstring = "Disconnect Button {Right Secondary}";
                break;
            }
        case 1:
            {
                disconnectbuttonstring = "Disconnect Button {Right Primary}";
                break;
            }
        case 2:
            {
                disconnectbuttonstring = "Disconnect Button {Left Secondary}";
                break;
            }
        case 3:
            {
                disconnectbuttonstring = "Disconnect Button {Left Primary}";
                break;
            }
        case 4:
            {
                disconnectbuttonstring = "Disconnect Button {Right Trigger}";
                break;
            }
        case 5:
            {
                disconnectbuttonstring = "Disconnect Button {Right Grab}";
                break;
            }
        case 6:
            {
                disconnectbuttonstring = "Disconnect Button {Left Trigger}";
                break;
            }
        case 7:
            {
                disconnectbuttonstring = "Disconnect Button {Left Grab}";
                break;
            }
    }
}
public static string disconnectbuttonstring = "bvb";
public static string disconnectbuttonstring = "Disconnect Button {Right Secondary}";
public static void DisconnectOnButton()
{
    switch (disconnectbutton)
@ -339,5 + 339,18 @@ namespace StupidTemplate.Mods
                GorillaTagger.Instance.rightHandTransform.transform.position = GorillaTagger.Instance.offlineVRRig.transform.position + new Vector3(0, -1, 0);
}
        }

        public static void RPCflush()
{
    GorillaTagger.Instance.myVRRig.SendRPC("RPC_PlaySplashEffect", RpcTarget.All, new object[]
            {
                        GorillaTagger.Instance.rightHandTransform.position,
                        GorillaTagger.Instance.rightHandTransform.rotation,
                        4f,
                        100f,
                        true,
                        false
            });
}
    }
}