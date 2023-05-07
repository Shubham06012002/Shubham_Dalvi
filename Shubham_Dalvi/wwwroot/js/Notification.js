const notificationType = {
    success: "success",
    danger: "danger",
    warning: "warning",
    info: "info",
}
const notificationImageMap = {
    success: "https://cdn-icons-png.flaticon.com/512/190/190411.png?w=740&t=st=1680439704~exp=1680440304~hmac=dda10615bcbe4834d44c9d3c7b803f332c51f7851f54c291677b466c6d84df90",
    danger: "https://cdn-icons-png.flaticon.com/512/179/179386.png?w=740&t=st=1680439772~exp=1680440372~hmac=a06299bb28435339ea2b4b0f6b4314c9edac03e085d37e98677d760e1cce9e54",
    warning: "https://cdn-icons-png.flaticon.com/512/1040/1040262.png?w=740&t=st=1680439823~exp=1680440423~hmac=9188075d52969fa82ff7d4ff01ca46b6c24c60c162f6fc02942aeb4171d0db45",
    info: "https://cdn-icons-png.flaticon.com/512/1040/1040263.png?w=740&t=st=1680439878~exp=1680440478~hmac=afd4121c482c15d02c7537dcaee75bb6585eae8cb19c0c3f19f71955142028fa"
}
function notify(type = notificationType.info, title = "", message = "", timer = null) {
    let notification = document.createElement("div");
    notification.style.width = "fit-content";
    notification.className += ("animate__animated animate__slideInLeft bg-body");
    notification.id = `cus-notification-key-${Math.floor(Math.random() * 100000)}`;
    notification.innerHTML = `
        <div class="small shadow notification rounded-2 d-flex p-2 mb-4 bg-${(type == 'info') ? 'primary' : type} ${(type == 'warning') ? 'text-dark bg-opacity-75' : 'text-white'}">
            <div class="col-2">
                <img src="${notificationImageMap[type]}"/ class="img-fluid">
            </div>
            <div class="col-10 ps-1">
 	  	        <div class="pb-1">
 			        <span class="fw-bold">${title}</span>
                    <button class="float-end btn btn-close ${(type != 'warning') && 'btn-close-white'} p-0" onclick="removeNotification('${notification.id}')">
                    </button>
                </div>
 		        <div class=""><p>${message}</p></div>
            </div>
 	    </div>`;
    document.getElementById("notification-container").appendChild(notification);
    //if (type == 'success' || timer != null)
    //{
    //    if (timer == null) timer =;
    //    setTimeout(() => removeNotification(notification.id), timer)
    //}
}
function removeNotification(key) {
    let notification = document.getElementById(key)
    notification.classList.add("fade");
    setTimeout(() => {
        notification.remove();
    },200000);
}
const notificationContainer = document.createElement("div");
notificationContainer.id = "notification-container";
notificationContainer.className = "m-5 position-absolute bottom-0 start-0 small";
notificationContainer.style.width = "320px"
document.querySelector("body").appendChild(notificationContainer);