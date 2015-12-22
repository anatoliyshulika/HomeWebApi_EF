function LampOnOff(id, name) {
    $.ajax({
        type: "PUT",
        url: "/api/LampsApi/" + id,
        data: { id: id },
        dataType: "json",
        success: function (data) {
            if (1 == data) {
                $("#" + name).find("._paneState").html("On");
                $("#" + name).find("._lampImage").prop("src", "/Content/Picture/LampOn.jpg");
            }
            else if (0 == data) {
                $("#" + name).find("._paneState").html("Off");
                $("#" + name).find("._lampImage").prop("src", "/Content/Picture/LampOff.jpg");
            }
        },
        error: function () {
            alert("Something went wrong!!!");
        }
    });
}
function LampDelete(id, name) {
    $.ajax({
        type: "DELETE",
        url: "/api/LampsApi/" + id,
        data: { id: id },
        dataType: "json",
        success: function (data) {
            if (1 == data) {
                $("#" + name).remove();
            }
        },
        error: function () {
            alert("Something went wrong!!!");
        }
    });
}
function AddDevice(typeOfDevice, name) {
    $.ajax({
        type: "POST",
        url: "/Home/AddDevice/",
        data: { modelName: name, typeOfDevice: typeOfDevice },
        //dataType: "html",
        success: function (data) {
            if (null != data) {
                $("#Device").append(data);
                $("#TextBoxNameOfDevice").val('');
            }
            else {
                alert("Вернувшиеся данные не верны!!!");
                $("#TextBoxNameOfDevice").val('');
            }
        },
        error: function () {
            alert("Something went wrong!!!");
        }
    });
}
function BurnerOnOff(id, name) {
    $.ajax({
        type: "PUT",
        url: "/api/BurnersApi/" + id,
        data: { id: id },
        dataType: "json",
        success: function (data) {
            if (1 == data) {
                $("#" + name).find("._burnerPanelState").html("On");
                $("#" + name).find("._burnerImage").prop("src", "/Content/Picture/BurnerLow.jpg");
            }
            else if (2 == data) {
                $("#" + name).find("._burnerPanelState").html("On");
                $("#" + name).find("._burnerImage").prop("src", "/Content/Picture/BurnerMedium.jpg");
            }
            else if (3 == data) {
                $("#" + name).find("._burnerPanelState").html("On");
                $("#" + name).find("._burnerImage").prop("src", "/Content/Picture/BurnerHeight.jpg");
            }
            else if (0 == data) {
                $("#" + name).find("._burnerPanelState").html("Off");
                $("#" + name).find("._burnerImage").prop("src", "/Content/Picture/BurnerOff.jpg");
            }
        },
        error: function () {
            alert("Something went wrong!!!");
        }
    });
}
function BurnerLevelDown(id, name) {
    $.ajax({
        type: "PUT",
        url: "/api/BurnersApi/PutLevelDown/" + id,
        data: { id: id },
        dataType: "json",
        success: function (data) {
            if (1 == data) {
                $("#" + name).find("._burnerImage").prop("src", "/Content/Picture/BurnerLow.jpg");
            }
            else if (2 == data) {
                $("#" + name).find("._burnerImage").prop("src", "/Content/Picture/BurnerMedium.jpg");
            }
            else if (3 == data) {
                $("#" + name).find("._burnerImage").prop("src", "/Content/Picture/BurnerHeight.jpg");
            }
        },
        error: function () {
            alert("Something went wrong!!!");
        }
    });
}
function BurnerLevelUp(id, name) {
    $.ajax({
        type: "PUT",
        url: "/api/BurnersApi/PutLevelUp/" + id,
        data: { id: id },
        dataType: "json",
        success: function (data) {
            if (1 == data) {
                $("#" + name).find("._burnerImage").prop("src", "/Content/Picture/BurnerLow.jpg");
            }
            else if (2 == data) {
                $("#" + name).find("._burnerImage").prop("src", "/Content/Picture/BurnerMedium.jpg");
            }
            else if (3 == data) {
                $("#" + name).find("._burnerImage").prop("src", "/Content/Picture/BurnerHeight.jpg");
            }
        },
        error: function () {
            alert("Something went wrong!!!");
        }
    });
}
function OvenOnOff(id, name) {
    $.ajax({
        type: "PUT",
        url: "/api/OvensApi/" + id,
        data: { id: id },
        dataType: "json",
        success: function (data) {
            if (1 == data) {
                $("#" + name).find("._panelOvenState").html("Oven On");
            }
            else if (0 == data) {
                $("#" + name).find("._panelOvenState").html("Oven Off");
            }
        },
        error: function () {
            alert("Something went wrong!!!");
        }
    });
}
function LampOvenOnOff(id, name) {
    $.ajax({
        type: "PUT",
        url: "/api/OvensApi/PutLampOvenOnOff/" + id,
        data: { id: id },
        dataType: "json",
        success: function (data) {
            if (1 == data) {
                $("#" + name).find("._panelOvenLampState").html("Lamp On");
            }
            else if (0 == data) {
                $("#" + name).find("._panelOvenLampState").html("Lamp Off");
            }
        },
        error: function () {
            alert("Something went wrong!!!");
        }
    });
}
function BakeDelete(id, name) {
    $.ajax({
        type: "DELETE",
        url: "/api/BakesApi/" + id,
        data: { id: id },
        dataType: "json",
        success: function (data) {
            if (1 == data) {
                $("#" + name).remove();
            }
        },
        error: function () {
            alert("Something went wrong!!!");
        }
    });
}
function FrigeDelete(id, name) {
    $.ajax({
        type: "DELETE",
        url: "/api/FrigesApi/" + id,
        data: { id: id },
        dataType: "json",
        success: function (data) {
            if (1 == data) {
                $("#" + name).remove();
            }
        },
        error: function () {
            alert("Something went wrong!!!");
        }
    });
}
function FrigeOnOff(id, name) {
    $.ajax({
        type: "PUT",
        url: "/api/FrigesApi/" + id,
        data: { id: id },
        dataType: "json",
        success: function (data) {
            if (1 == data) {
                $("#" + name).find("._frigePanelFrizingLevel").html("Frizing level - Low");
                $("#" + name).find("._paneState").html("On");
            }
            else if (2 == data) {
                $("#" + name).find("._frigePanelFrizingLevel").html("Frizing level - Medium");
                $("#" + name).find("._paneState").html("On");
            }
            else if (3 == data) {
                $("#" + name).find("._frigePanelFrizingLevel").html("Frizing level - Height");
                $("#" + name).find("._paneState").html("On");
            }
            else if (0 == data) {
                $("#" + name).find("._paneState").html("Off");
                $("#" + name).find("._frigePanelFrizingLevel").html("Frizing level");
            }
        },
        error: function () {
            alert("Something went wrong!!!");
        }
    });
}
function LampFrigeOnOff(id, name) {
    $.ajax({
        type: "PUT",
        url: "/api/FrigesApi/PutLampFrigeOnOff/" + id,
        data: { id: id },
        dataType: "json",
        success: function (data) {
            if (1 == data) {
                $("#" + name).find("._frigePanelLampState").html("Lamp On");
            }
            else if (0 == data) {
                $("#" + name).find("._frigePanelLampState").html("Lamp Off");
            }
        },
        error: function () {
            alert("Something went wrong!!!");
        }
    });
}
function FrigeLevelDown(id, name) {
    $.ajax({
        type: "PUT",
        url: "/api/FrigesApi/PutLevelDown/" + id,
        data: { id: id },
        dataType: "json",
        success: function (data) {
            if (1 == data) {
                $("#" + name).find("._frigePanelFrizingLevel").html("Frizing level - Low");
            }
            else if (2 == data) {
                $("#" + name).find("._frigePanelFrizingLevel").html("Frizing level - Medium");
            }
            else if (3 == data) {
                $("#" + name).find("._frigePanelFrizingLevel").html("Frizing level - Height");
            }
        },
        error: function () {
            alert("Something went wrong!!!");
        }
    });
}
function FrigeLevelUp(id, name) {
    $.ajax({
        type: "PUT",
        url: "/api/FrigesApi/PutLevelUp/" + id,
        data: { id: id },
        dataType: "json",
        success: function (data) {
            if (1 == data) {
                $("#" + name).find("._frigePanelFrizingLevel").html("Frizing level - Low");
            }
            else if (2 == data) {
                $("#" + name).find("._frigePanelFrizingLevel").html("Frizing level - Medium");
            }
            else if (3 == data) {
                $("#" + name).find("._frigePanelFrizingLevel").html("Frizing level - Height");
            }
        },
        error: function () {
            alert("Something went wrong!!!");
        }
    });
}
function TVDelete(id, name) {
    $.ajax({
        type: "DELETE",
        url: "/api/TVsApi/" + id,
        data: { id: id },
        dataType: "json",
        success: function (data) {
            if (1 == data) {
                $("#" + name).remove();
            }
        },
        error: function () {
            alert("Something went wrong!!!");
        }
    });
}
function TVOnOff(id, name) {
    $.ajax({
        type: "PUT",
        url: "/api/TVsApi/" + id,
        data: { id: id },
        dataType: "json",
        success: function (data) {
            if (1 == data) {
                $("#" + name).find("._paneState").html("On");
                $("#" + name).find("._tvImage").prop("src", "/Content/Picture/1.gif");
                $("#" + name).find("._tvPanelVolume").html("Volume - Low");
            }
            else if (2 == data) {
                $("#" + name).find("._paneState").html("On");
                $("#" + name).find("._tvImage").prop("src", "/Content/Picture/2.gif");
                $("#" + name).find("._tvPanelVolume").html("Volume - Low");
            }
            else if (3 == data) {
                $("#" + name).find("._paneState").html("On");
                $("#" + name).find("._tvImage").prop("src", "/Content/Picture/3.gif");
                $("#" + name).find("._tvPanelVolume").html("Volume - Low");
            }
            else if (4 == data) {
                $("#" + name).find("._paneState").html("On");
                $("#" + name).find("._tvImage").prop("src", "/Content/Picture/4.gif");
                $("#" + name).find("._tvPanelVolume").html("Volume - Low");
            }
            else if (5 == data) {
                $("#" + name).find("._paneState").html("On");
                $("#" + name).find("._tvImage").prop("src", "/Content/Picture/5.gif");
                $("#" + name).find("._tvPanelVolume").html("Volume - Low");
            }
            else if (6 == data) {
                $("#" + name).find("._paneState").html("On");
                $("#" + name).find("._tvImage").prop("src", "/Content/Picture/6.gif");
                $("#" + name).find("._tvPanelVolume").html("Volume - Low");
            }
            else if (7 == data) {
                $("#" + name).find("._paneState").html("On");
                $("#" + name).find("._tvImage").prop("src", "/Content/Picture/7.gif");
                $("#" + name).find("._tvPanelVolume").html("Volume - Low");
            }
            else if (8 == data) {
                $("#" + name).find("._paneState").html("On");
                $("#" + name).find("._tvImage").prop("src", "/Content/Picture/8.gif");
                $("#" + name).find("._tvPanelVolume").html("Volume - Low");
            }
            else if (9 == data) {
                $("#" + name).find("._paneState").html("On");
                $("#" + name).find("._tvImage").prop("src", "/Content/Picture/9.gif");
                $("#" + name).find("._tvPanelVolume").html("Volume - Low");
            }
            else if (10 == data) {
                $("#" + name).find("._paneState").html("On");
                $("#" + name).find("._tvImage").prop("src", "/Content/Picture/10.gif");
                $("#" + name).find("._tvPanelVolume").html("Volume - Low");
            }
            else if (0 == data) {
                $("#" + name).find("._paneState").html("Off");
                $("#" + name).find("._tvImage").prop("src", "/Content/Picture/TVoff.jpg");
                $("#" + name).find("._tvPanelVolume").html("Volume");
            }
        },
        error: function () {
            alert("Something went wrong!!!");
        }
    });
}
function TVChannelDown(id, name) {
    $.ajax({
        type: "PUT",
        url: "/api/TVsApi/PutChennelDown/" + id,
        data: { id: id },
        dataType: "json",
        success: function (data) {
            if (1 == data) {
                $("#" + name).find("._tvImage").prop("src", "/Content/Picture/1.gif");
            }
            else if (2 == data) {
                $("#" + name).find("._tvImage").prop("src", "/Content/Picture/2.gif");
            }
            else if (3 == data) {
                $("#" + name).find("._tvImage").prop("src", "/Content/Picture/3.gif");
            }
            else if (4 == data) {
                $("#" + name).find("._tvImage").prop("src", "/Content/Picture/4.gif");
            }
            else if (5 == data) {
                $("#" + name).find("._tvImage").prop("src", "/Content/Picture/5.gif");
            }
            else if (6 == data) {
                $("#" + name).find("._tvImage").prop("src", "/Content/Picture/6.gif");
            }
            else if (7 == data) {
                $("#" + name).find("._tvImage").prop("src", "/Content/Picture/7.gif");
            }
            else if (8 == data) {
                $("#" + name).find("._tvImage").prop("src", "/Content/Picture/8.gif");
            }
            else if (9 == data) {
                $("#" + name).find("._tvImage").prop("src", "/Content/Picture/9.gif");
            }
            else if (10 == data) {
                $("#" + name).find("._tvImage").prop("src", "/Content/Picture/10.gif");
            }
        },
        error: function () {
            alert("Something went wrong!!!");
        }
    });
}
function TVChannelUp(id, name) {
    $.ajax({
        type: "PUT",
        url: "/api/TVsApi/PutChennelUp/" + id,
        data: { id: id },
        dataType: "json",
        success: function (data) {
            if (1 == data) {
                $("#" + name).find("._tvImage").prop("src", "/Content/Picture/1.gif");
            }
            else if (2 == data) {
                $("#" + name).find("._tvImage").prop("src", "/Content/Picture/2.gif");
            }
            else if (3 == data) {
                $("#" + name).find("._tvImage").prop("src", "/Content/Picture/3.gif");
            }
            else if (4 == data) {
                $("#" + name).find("._tvImage").prop("src", "/Content/Picture/4.gif");
            }
            else if (5 == data) {
                $("#" + name).find("._tvImage").prop("src", "/Content/Picture/5.gif");
            }
            else if (6 == data) {
                $("#" + name).find("._tvImage").prop("src", "/Content/Picture/6.gif");
            }
            else if (7 == data) {
                $("#" + name).find("._tvImage").prop("src", "/Content/Picture/7.gif");
            }
            else if (8 == data) {
                $("#" + name).find("._tvImage").prop("src", "/Content/Picture/8.gif");
            }
            else if (9 == data) {
                $("#" + name).find("._tvImage").prop("src", "/Content/Picture/9.gif");
            }
            else if (10 == data) {
                $("#" + name).find("._tvImage").prop("src", "/Content/Picture/10.gif");
            }
        },
        error: function () {
            alert("Something went wrong!!!");
        }
    });
}
function TVVolemeDown(id, name) {
    $.ajax({
        type: "PUT",
        url: "/api/TVsApi/PutVolumeDown/" + id,
        data: { id: id },
        dataType: "json",
        success: function (data) {
            if (1 == data) {
                $("#" + name).find("._tvPanelVolume").html("Volume - Low");
            }
            else if (2 == data) {
                $("#" + name).find("._tvPanelVolume").html("Volume - Medium");
            }
            else if (3 == data) {
                $("#" + name).find("._tvPanelVolume").html("Volume - Height");
            }
        },
        error: function () {
            alert("Something went wrong!!!");
        }
    });
}
function TVVolemeUp(id, name) {
    $.ajax({
        type: "PUT",
        url: "/api/TVsApi/PutVolumeUp/" + id,
        data: { id: id },
        dataType: "json",
        success: function (data) {
            if (1 == data) {
                $("#" + name).find("._tvPanelVolume").html("Volume - Low");
            }
            else if (2 == data) {
                $("#" + name).find("._tvPanelVolume").html("Volume - Medium");
            }
            else if (3 == data) {
                $("#" + name).find("._tvPanelVolume").html("Volume - Height");
            }
        },
        error: function () {
            alert("Something went wrong!!!");
        }
    });
}
function RadioOnOff(id, name) {
    $.ajax({
        type: "PUT",
        url: "/api/RadiosApi/" + id,
        data: { id: id },
        dataType: "json",
        success: function (data) {
            if (1 == data) {
                $("#" + name).find("._paneState").html("On");
                $("#" + name).find("._radioImage").prop("src", "/Content/Picture/Radio.gif");
                $("#" + name).find("._radioPanelVolume").html("Volume - Low");
            }
            else if (0 == data) {
                $("#" + name).find("._paneState").html("Off");
                $("#" + name).find("._radioImage").prop("src", "/Content/Picture/RadioOff.jpg");
                $("#" + name).find("._radioPanelVolume").html("Volume");
            }
        },
        error: function () {
            alert("Something went wrong!!!");
        }
    });
}
function RadioDelete(id, name) {
    $.ajax({
        type: "DELETE",
        url: "/api/RadiosApi/" + id,
        data: { id: id },
        dataType: "json",
        success: function (data) {
            if (1 == data) {
                $("#" + name).remove();
            }
        },
        error: function () {
            alert("Something went wrong!!!");
        }
    });
}
function RadioVolemeDown(id, name) {
    $.ajax({
        type: "PUT",
        url: "/api/RadiosApi/PutVolumeDown/" + id,
        data: { id: id },
        dataType: "json",
        success: function (data) {
            if (1 == data) {
                $("#" + name).find("._radioPanelVolume").html("Volume - Low");
            }
            else if (2 == data) {
                $("#" + name).find("._radioPanelVolume").html("Volume - Medium");
            }
            else if (3 == data) {
                $("#" + name).find("._radioPanelVolume").html("Volume - Height");
            }
        },
        error: function () {
            alert("Something went wrong!!!");
        }
    });
}
function RadioVolemeUp(id, name) {
    $.ajax({
        type: "PUT",
        url: "/api/RadiosApi/PutVolumeUp/" + id,
        data: { id: id },
        dataType: "json",
        success: function (data) {
            if (1 == data) {
                $("#" + name).find("._radioPanelVolume").html("Volume - Low");
            }
            else if (2 == data) {
                $("#" + name).find("._radioPanelVolume").html("Volume - Medium");
            }
            else if (3 == data) {
                $("#" + name).find("._radioPanelVolume").html("Volume - Height");
            }
        },
        error: function () {
            alert("Something went wrong!!!");
        }
    });
}