Show_Legend = (view, Legend) => {

    var legend = new Legend({ // Creates legend widget
        view: view,

    });

    view.ui.add(legend, "bottom-left"); //Places legend widget

    var handle = view.watch("zoom", function (newValue, oldValue, property, object) {
        if (newValue < 14) {
            view.ui.remove(legend);
        } else {
            view.ui.add(legend, "bottom-left");
        }
    });
}


