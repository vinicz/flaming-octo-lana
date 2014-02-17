#pragma strict
var publisherId : String = "a1510269fda61bf";
var refreshRate : float = 60.0;
var testDevice : String = "test_device_code_here";
function Start () {
    AdBannerObserver.Initialize(publisherId, testDevice, refreshRate);
}
