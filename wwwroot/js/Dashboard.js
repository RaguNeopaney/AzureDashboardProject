new Chart(document.getElementById("myChart"), {
    type: 'bar',
    data: {
        labels: ["2018", "2019", "2020"],
        datasets: [
            {
                label: "Total Sales",
                backgroundColor: ["#3e95cd", "#8e5ea2", "#3cba9f"],
                data: [228258, 591299, 374452]
            }
        ]
    },
    options: {
        legend: { display: false },
        title: {
            display: true,
            text: 'Total Sales for year'
        },
        scales: {
            yAxes: [{
                scaleLabel: {
                    display: true,
                    labelString: 'Total Sales Unit',
                    fontColor: "#004d00"
                }
            }],
            xAxes: [{
                scaleLabel: {
                    display: true,
                    labelString: 'Years',
                    fontColor: "#004d00"
                }
            }],
        }
    }
});

new Chart(document.getElementById("GroupChart"), {
    type: 'bar',
    data: {
        labels: ["2018", "2019", "2020"],
        datasets: [
            {
                label: "Central",
                backgroundColor: "#3e95cd",
                data: [142899.19, 376349.47, 272375.56]
            }, {
                label: "West",
                backgroundColor: "#81f542",
                data: [169282.13, 431634.68, 278476.36]
            }, {
                label: "South",
                backgroundColor: "#f542ec",
                data: [153714.16, 409256.72, 264352.47]
            }, {
                label: "East",
                backgroundColor: "#f54242",
                data: [187450.46, 506277.78, 334394.54]
            },

        ]
    },
    options: {
        title: {
            display: true,
            text: 'Total Sales for year For Each Region'
        },
        scales: {
            yAxes: [{
                ticks: {
                    // Include a dollar sign in the ticks
                    callback: function (value, index, values) {
                        return '$' + value;
                    }
                },
                scaleLabel: {
                    display: true,
                    labelString: 'Total Sales ($)',
                    fontColor: "#004d00"
                }
            }],
            xAxes: [{
                scaleLabel: {
                    display: true,
                    labelString: 'Years',
                    fontColor: "#004d00"
                }
            }]
        }
    }
});
let MyScale = Chart.Scale.extend({
    /* extensions ... */
});

new Chart(document.getElementById("myLineChart"), {
    type: 'line',
    data: {
        labels: ["438", "2512", "1241", "60", "1245", "2629", "3904", "815", "1102", "3496"],
        datasets: [{
            data: ["35807.22", "32915.63", "31716.87", "30628.33", "29224.17", "29054.05", "28125.35", "27660.05", "26670.43", "26374.71"],
            label: "Household Total Spending in 3 Yrs",
            borderColor: "#3e95cd",
            fill: true
        }
        ]
    },
    options: {
        title: {
            display: true,
            text: 'Top 10 Households Spending In 3 Years (high-low spending)'
        },
        scales: {
            yAxes: [{
                ticks: {
                    // Include a dollar sign in the ticks
                    callback: function (value, index, values) {
                        return '$' + value;
                    },
                },
                scaleLabel: {
                    display: true,
                    labelString: 'Total Spend ($)',
                    fontColor: "#004d00"
                }
            }],
            xAxes: [{
                scaleLabel: {
                    display: true,
                    labelString: 'Household',
                    fontColor: "#004d00",
                },
            }]
        }
    }
});