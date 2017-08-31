import toga

def build(app):
    table_container = toga.Table(['Hello', 'World'])

    table_container.insert(None, 'root1', 'value1')
    table_container.insert(None, 'root2', 'value2')
    table_container.insert(None, 'root3', 'value3')
    table_container.insert(1, 'root4', 'value4')

    for i in range(0, 100):
        table_container.insert(None, 'root%s' % (i+5), 'value%s' % (i+5))

    return table_container


def main():
    return toga.App('Table Sample App', 'org.pybee.f_to_c', startup=build)

if __name__ == '__main__':
    main().main_loop()