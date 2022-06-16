# AR Foundation Implementing Virtual Background Research 
A general research into AR Foundation 5.0 on verified Unity 2021.3.4f1 LTS as of 2022 June, which relies on three Unity packages:
* Google ARCore XR Plug-in ([documentation](https://docs.unity3d.com/Packages/com.unity.xr.arcore@5.0/manual/index.html))
* Apple ARKit XR Plug-in ([documentation](https://docs.unity3d.com/Packages/com.unity.xr.arkit@5.0/manual/index.html))
* ARFoundation ([documentation](https://docs.unity3d.com/Packages/com.unity.xr.arfoundation@5.0/manual/index.html))

To experiment with this project or any AR Foundation related application, an Apple device with A12 Bionic chip running iOS 13 or later is ideal. 

Below are some helpful resources with descriptions of their purposes accumulated throughout:
* [**AR Foundation Samples**](https://github.com/Unity-Technologies/arfoundation-samples) 
The official and most updated AR Foundation samples collection provided by Unity. The focus of this research is on CpuImages, Human Stencil in DepthImages, and Occlusion.
* [**AR Foundations Upgrade Guide**](https://docs.unity3d.com/Packages/com.unity.xr.arfoundation@5.0/manual/upgrade-guide.html) 
Includes migration guides from AR Foundation 1.0 to any recent versions. This is especially helpful when you are reading into older projects such as the [Unity AR Foundation Essentials Guide](https://github.com/dilmerv/UnityARFoundationEssentials), its associated [Augmented Reality Development Tutorials](https://youtube.com/playlist?list=PLQMQNmwN3FvzFLpLRxA8Xa1zRypFeVav5), and [Ar Foundation Occlusion](https://github.com/dilmerv/ARFoundationOcclusion/tree/feature/URPOcclusion), all created by Dilmer Valecillos.
==Note==: when you are browsing through Unity's official [AR Foundation Documentation](https://docs.unity3d.com/Packages/com.unity.xr.arfoundation@5.0/manual/index.html), make sure it's version on the top left dropdown list matches the one you are looking for. 
* [**Google Getting Started with AR Foundation**](https://developers.google.com/ar/develop/unity-arf/getting-started-ar-foundation#install_ar_foundation) 
An incredibly helpful guide on establishing a skeleton setup of AR Foundation in both the Android environment and the IOS environment. Also includes a [demo](https://codelabs.developers.google.com/arcore-unity-ar-foundation#0), but only in Android implementation.
*

## AR Foundation Application Skeleton Setup

Technical Requirements:
* Laptop running on native or virtual MacOS environment capable of installing and supporting the most recent versions of [Unity](https://unity.com) and [Xcode](https://developer.apple.com/xcode/).
* Aforementioned Apple device with A12 Bionic chip running iOS 13, preferably an iPad.
