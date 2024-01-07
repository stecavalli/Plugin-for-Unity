package com.stecavalli.mylibrary;       // This line of code needs to be changed if you used
                                        // a different name for creating the Module.

import android.content.Context;
import android.hardware.camera2.CameraAccessException;
import android.hardware.camera2.CameraManager;

public class FlashlightPlugin {
    private static boolean isFlashOn = false;

    public static void toggleFlashlight(Context context) {
        CameraManager cameraManager = (CameraManager) context.getSystemService(Context.CAMERA_SERVICE);

        try {
            String cameraId = cameraManager.getCameraIdList()[0];
            isFlashOn = !isFlashOn;
            cameraManager.setTorchMode(cameraId, isFlashOn);
        } catch (CameraAccessException e) {
            e.printStackTrace();
            // Gestire l'eccezione appropriata
        }
    }
}
