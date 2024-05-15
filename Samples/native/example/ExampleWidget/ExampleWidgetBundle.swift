//
//  ExampleWidgetBundle.swift
//  ExampleWidget
//
//  Created by Brian Smith on 11/30/22.
//

import WidgetKit
import SwiftUI

@main
struct ExampleWidgetBundle: WidgetBundle {
    var body: some Widget {
        if #available(iOS 16.1, *) {
            ExampleWidgetLiveActivity()
        }
    }
}
