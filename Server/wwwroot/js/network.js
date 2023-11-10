window.displayNetwork = (nodes, edges) => {
    // create a network
    var container = document.getElementById('mynetwork');
    var data = {
        nodes: new vis.DataSet(nodes),
        edges: new vis.DataSet(edges)
    };
    var options = {};
    var network = new vis.Network(container, data, options);
};